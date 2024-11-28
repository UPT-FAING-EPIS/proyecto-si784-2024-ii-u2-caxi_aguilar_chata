[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/OT8lK55O)
[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=15604050)


<div align="center">
 PROYECTO RUMI
  
![image](https://github.com/user-attachments/assets/2f5eb2d2-d671-49f3-8fd3-7c1416f8fcb3)
  
| Integrantes                       |
|-----------------------------------|
| AGUILAR PINTO Victor Eleazar      |
| CAXI CALANI Luis Eduardo          |
| CHATA CHOQUE Brant Antony         |

</div>


<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Informe de Auditoría - Proyecto RUMI</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        h1, h2, h3, h4, h5 {
            text-align: center;
        }
        table {
            width: 80%;
            margin: auto;
            border-collapse: collapse;
        }
        th, td {
            border: 1px solid #000;
            padding: 8px;
            text-align: center;
        }
        ul {
            list-style-type: none;
            text-align: center;
        }
        .center {
            text-align: center;
        }
        .button-container {
            display: flex;
            justify-content: center;
            gap: 10px;
            margin: 20px 0;
        }
        .button-container a img {
            width: 200px;
            height: auto;
        }
        img {
            display: block;
            margin: auto;
        }
    </style>
</head>
<body>

   <center>
        <img src="./media/logo-upt.png" alt="Logo UPT" style="width:100px;height:100px;">
        <h1>UNIVERSIDAD PRIVADA DE TACNA</h1>
        <h2>FACULTAD DE INGENIERIA</h2>
        <h3>Escuela Profesional de Ingeniería de Sistemas</h3>
        <h3>Proyecto <i>RUMI</i></h3>
        <h4>Curso: Calidad y Pruebas de Software</h4>
        <h4>Docente: MSc. Ing. Patrick Jose Cuadros Quiroga</h4>
        <h4>Integrantes:</h4>
        <ul>
            <li><b>CAXI CALANI Luis Eduardo</b> (2018062487)</li>
            <li><b>AGUILAR PINTO Victor Eleazar</b> (2018062487)</li>
            <li><b>CHATA CHOQUE Brant Antony</b> (2018062487)</li>
        </ul>
        <h4>Tacna – Perú, 2024</h4>
    </center>

   <div style="page-break-after: always; visibility: hidden">\pagebreak</div>

   <h1 class="center">Sistema Web de Recompensas por Participaciones para Jóvenes</h1>
    <h2 class="center">Informe de Auditoría de Seguridad y Código</h2>
    <h3 class="center">Versión 1.0</h3>

    <!-- Botones de revisión -->
   <div class="button-container">
        <a href="https://classroom.github.com/a/OT8lK55O" target="_blank">
            <img src="https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg" alt="Review Assignment Due Date">
        </a>
        <a href="https://classroom.github.com/open-in-codespaces?assignment_repo_id=15604050" target="_blank">
            <img src="https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg" alt="Open in Codespaces">
        </a>
   </div>

   <div align="center">
        <h3>PROYECTO RUMI</h3>
        <img src="https://github.com/user-attachments/assets/2f5eb2d2-d671-49f3-8fd3-7c1416f8fcb3" alt="Proyecto RUMI Image" style="width:600px;height:auto;">
        
   <table>
            <thead>
                <tr>
                    <th>Integrantes</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>AGUILAR PINTO Victor Eleazar</td>
                </tr>
                <tr>
                    <td>CAXI CALANI Luis Eduardo</td>
                </tr>
                <tr>
                    <td>CHATA CHOQUE Brant Antony</td>
                </tr>
            </tbody>
        </table>
   </div>

   <div style="page-break-after: always; visibility: hidden"></div>

   <h3>CONTROL DE VERSIONES</h3>
    <table>
        <thead>
            <tr>
                <th>Versión</th>
                <th>Hecha por</th>
                <th>Revisada por</th>
                <th>Aprobada por</th>
                <th>Fecha</th>
                <th>Motivo</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>1.0</td>
                <td>AC VA LC</td>
                <td>PCQ</td>
                <td>PCQ</td>
                <td>17/09/2024</td>
                <td>Versión Inicial</td>
            </tr>
         <tr>
                <td>2.0</td>
                <td>AC VA LC</td>
                <td>PCQ</td>
                <td>PCQ</td>
                <td>21/09/2024</td>
                <td>Segunda Revision</td>
            </tr>
         <tr>
                <td>3.0</td>
                <td>AC VA LC</td>
                <td>PCQ</td>
                <td>PCQ</td>
                <td>03/10/2024</td>
                <td>Versión Final</td>
            </tr>
        </tbody>
    </table>

   <div style="page-break-after: always; visibility: hidden"></div>

   <h3 id="indice-general">INDICE GENERAL</h3>
    <ul>
        <li><a href="#resumen">Resumen</a></li>
        <li><a href="#antecedentes">Antecedentes o Introducción</a></li>
        <li><a href="#planteamiento">Planteamiento del Problema</a></li>
        <li><a href="#objetivos">Objetivos</a></li>
        <li><a href="#metodologia">Metodología</a></li>
        <li><a href="#resultados">Resultados del Análisis</a></li>
        <li><a href="#conclusiones">Conclusiones</a></li>
    </ul>

   <h3 id="resumen">Resumen</h3>
    <p>Este informe documenta las auditorías de seguridad y calidad realizadas en la aplicación RUMI utilizando las herramientas Snyk y SonarQube. Los resultados muestran vulnerabilidades y problemas de calidad que deben ser abordados para mejorar la seguridad y mantenibilidad de la aplicación.</p>

   <h3 id="antecedentes">Antecedentes o Introducción</h3>
    <p>El proyecto RUMI es una aplicación web que promueve la participación de jóvenes a través de un sistema de recompensas. La auditoría fue realizada como parte del curso "Calidad y Pruebas de Software" con el objetivo de identificar vulnerabilidades de seguridad y problemas de calidad del código fuente.</p>

   <h3 id="planteamiento">Planteamiento del Problema</h3>
    <p>La auditoría de la aplicación RUMI identificó una serie de problemas críticos en la seguridad y calidad del código, incluyendo:</p>
    <ul>
        <li>Uso de algoritmos de hash inseguros para contraseñas.</li>
        <li>Falta de validación de tokens anti-forgery, exponiendo la aplicación a ataques CSRF.</li>
        <li>Versión obsoleta de bibliotecas, facilitando ataques de XSS.</li>
        <li>Alta duplicación de código que incrementa la deuda técnica y dificulta el mantenimiento.</li>
    </ul>

   <h3 id="objetivos">Objetivos</h3>
    <h4>Objetivo General</h4>
    <p>Mejorar la seguridad y la calidad del código de la aplicación RUMI mediante la corrección de vulnerabilidades identificadas y la optimización de las prácticas de desarrollo.</p>
    <h4>Objetivos Específicos</h4>
    <ul>
        <li>Implementar un algoritmo de hash seguro para las contraseñas.</li>
        <li>Habilitar la validación de tokens anti-forgery en los formularios POST.</li>
        <li>Reducir la duplicación de código y mejorar la mantenibilidad.</li>
        <li>Desactivar características de depuración en entornos de producción.</li>
    </ul>

   <h3 id="metodologia">Metodología</h3>
    <p>Se utilizaron las siguientes herramientas y metodologías para la auditoría:</p>
    <ul>
        <li><b>Snyk:</b> Para la identificación de vulnerabilidades en las dependencias y código fuente.</li>
        <li><b>SonarQube:</b> Para el análisis estático del código y evaluación de la calidad de desarrollo.</li>
    </ul>
   <!-- Imagen agregada en la sección de Metodología -->
    <h4>Diagrama de Integración Continua</h4>
    <p>A continuación se muestra el flujo del proceso de integración continua para la auditoría de seguridad y calidad del código:</p>
    ![integracion_continua](https://github.com/user-attachments/assets/c4b7c590-dbe1-437d-b79d-1e2eecf997cc)


   <h3 id="resultados">Resultados del Análisis</h3>
    <h4>Análisis con Snyk</h4>
    <p>El análisis con Snyk identificó un total de 45 vulnerabilidades, clasificadas como:</p>
    <ul>
        <li>1 de severidad media (habilitación de características de depuración).</li>
        <li>44 de severidad baja (uso de MD5, dependencias obsoletas, falta de validación de tokens).</li>
    </ul>
    <h4>Análisis con SonarQube</h4>
    <p>El análisis con SonarQube reveló:</p>
    <ul>
        <li>2 problemas críticos de seguridad.</li>
        <li>46 Security Hotspots que requieren revisión.</li>
        <li>849 problemas de fiabilidad, incluyendo 9 de alta prioridad.</li>
        <li>25.3% de duplicación de código.</li>
        <li>Cobertura de pruebas del 0%.</li>
    </ul>

   <h3 id="conclusiones">Conclusiones</h3>
    <p>Se han identificado varias áreas críticas de mejora en la aplicación RUMI. Se recomienda corregir los problemas de seguridad y reducir la duplicación de código para optimizar la mantenibilidad y reducir la deuda técnica.</p>

   <div style="page-break-after: always; visibility: hidden">\pagebreak</div>
</body>
</html>


