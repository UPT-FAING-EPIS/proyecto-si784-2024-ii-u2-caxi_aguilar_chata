using System;
using Xunit;
using Moq;
using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Controllers;
using Proyecto_Web2_Aguilar_Chino_Gonzales_Perez.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class TransferSteps
{
    private readonly TransferenciaController _controller;
    private readonly Mock<ModeloSistema> _mockDb;
    private ActionResult _result;
    private decimal _saldoEmisor;
    private string _mensajeError;
    private string _mensajeExito;

    public TransferSteps()
    {
        _mockDb = new Mock<ModeloSistema>();
        _controller = new TransferenciaController
        {
            Session = new MockHttpSession() // Simula la sesión
        };
    }

    [Fact]
    public void TransferenciaExitosa_DeberiaReducirSaldoEmisor()
    {
        // Arrange
        var userId = 1;
        var receptorId = 2;
        var montoTransferencia = 500m;
        _saldoEmisor = 1000m;

        SetupUsuario(userId, _saldoEmisor);
        SetupUsuario(receptorId, 0);

        _controller.Session["UserID"] = userId;

        // Act
        _result = _controller.Transferir(receptorId, montoTransferencia);

        // Assert
        var emisor = _mockDb.Object.usuarios.Single(u => u.id_usuario == userId);
        var receptor = _mockDb.Object.usuarios.Single(u => u.id_usuario == receptorId);

        Assert.Equal(500m, emisor.saldo);
        Assert.Equal(500m, receptor.saldo);
        Assert.IsType<RedirectToActionResult>(_result);
        Assert.Equal("Transferir", ((RedirectToActionResult)_result).ActionName);
    }

    [Fact]
    public void TransferenciaSaldoInsuficiente_DeberiaMostrarError()
    {
        // Arrange
        var userId = 1;
        var receptorId = 2;
        var montoTransferencia = 500m;
        _saldoEmisor = 100m;

        SetupUsuario(userId, _saldoEmisor);
        SetupUsuario(receptorId, 0);

        _controller.Session["UserID"] = userId;

        // Act
        _result = _controller.Transferir(receptorId, montoTransferencia);

        // Assert
        Assert.Equal("Saldo insuficiente.", _controller.TempData["ErrorMessage"]);
        Assert.IsType<RedirectToActionResult>(_result);
        Assert.Equal("Transferir", ((RedirectToActionResult)_result).ActionName);
    }

    [Fact]
    public void TransferenciaAUsuarioInexistente_DeberiaMostrarError()
    {
        // Arrange
        var userId = 1;
        var receptorId = 9999; // Usuario inexistente
        var montoTransferencia = 500m;

        SetupUsuario(userId, 1000m);

        _controller.Session["UserID"] = userId;

        // Act
        _result = _controller.Transferir(receptorId, montoTransferencia);

        // Assert
        Assert.Equal("Receptor no encontrado.", _controller.TempData["ErrorMessage"]);
        Assert.IsType<RedirectToActionResult>(_result);
        Assert.Equal("Transferir", ((RedirectToActionResult)_result).ActionName);
    }

    [Fact]
    public void TransferenciaASiMismo_DeberiaMostrarError()
    {
        // Arrange
        var userId = 1;
        var montoTransferencia = 500m;

        SetupUsuario(userId, 1000m);

        _controller.Session["UserID"] = userId;

        // Act
        _result = _controller.Transferir(userId, montoTransferencia);

        // Assert
        Assert.Equal("El usuario no es válido.", _controller.TempData["ErrorMessage"]);
        Assert.IsType<RedirectToActionResult>(_result);
        Assert.Equal("Transferir", ((RedirectToActionResult)_result).ActionName);
    }

    private void SetupUsuario(int id, decimal saldo)
    {
        var usuario = new usuario { id_usuario = id, saldo = saldo };
        _mockDb.Setup(db => db.usuarios.SingleOrDefault(u => u.id_usuario == id))
            .Returns(usuario);
    }
}

// Mock para la sesión
public class MockHttpSession : Dictionary<string, object>, ISession
{
    public string Id => Guid.NewGuid().ToString();
    public bool IsAvailable => true;

    public IEnumerable<string> Keys => this.Keys;

    public void Clear() => this.Clear();

    public void Remove(string key) => this.Remove(key);

    public void Set(string key, byte[] value) => this[key] = value;

    public bool TryGetValue(string key, out byte[] value)
    {
        if (this.TryGetValue(key, out var objValue))
        {
            value = objValue as byte[];
            return true;
        }

        value = null;
        return false;
    }

    public byte[] Get(string key) => this[key] as byte[];
}
