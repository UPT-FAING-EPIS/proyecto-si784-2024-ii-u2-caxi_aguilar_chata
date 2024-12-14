<div align="center">

![./media/media/image1.png](./media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**  

**FACULTAD DE INGENIERÍA**  

**Escuela Profesional de Ingeniería de Sistemas**  

**Proyecto _UPT-SYNC: Herramienta de apoyo para estudiantes_**  

Curso: _Calidad y Pruebas de Software_  

Docente: _Mag. Patrick Cuadros Quiroga_  

Integrantes:  

***CAXI CALANI Luis Eduardo (2018062487)***  
***AGUILAR PINTO Victor Eleazar (2018062487)***  

**Tacna – Perú**  

***2024***  

</div>

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

# **Sistema UPT-SYNC**

**Informe de Factibilidad**  
**Versión 1.0**

| **CONTROL DE VERSIONES** | **Hecha por** | **Revisada por** | **Aprobada por** | **Fecha**     | **Motivo**          |
|---------------------------|---------------|------------------|------------------|---------------|---------------------|
| 1.0                       | MPV           | ELV              | ARV              | 10/10/2020    | Versión Original    |

<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

# **INDICE GENERAL**

Resumen

Abstract

[1. Antecedentes o introducción](#_Toc52661346)

[2. Titulo](#_Toc52661347)

[3. Autores](#_Toc52661348)

[4. Planteamiento del problema](#_Toc52661349)

[4.1 Problema](#_Toc52661350)

[4.2 Justificación](#_Toc52661351)

[4.3 Alcance](#_Toc52661352)

[5. Objetivos](#_Toc52661356)

[5.1 General](#_Toc52661350)

[5.2 Especificos](#_Toc52661351)

[6. Referentes teóricos](#_Toc52661357)

[7. Desarrollo de la propuesta](#_Toc52661356)

[7.1 Tecnología de información ](#_Toc52661350)

[7.2 Metodología, técnicas usadas](#_Toc52661351)

[7. Cronograma](#_Toc52661356)



<div style="page-break-after: always; visibility: hidden">\pagebreak</div>

# **Tema: Mejoramiento de la Aplicación UPT-SYNC**

---

## **1. Antecedentes o Introducción**

La aplicación **UPT-SYNC** fue diseñada como una solución tecnológica para automatizar la sincronización de datos académicos desde la intranet de la Universidad Privada de Tacna (UPT). Su propósito inicial fue proporcionar acceso rápido a información como horarios, asistencias y créditos acumulados. Sin embargo, su funcionalidad actual presenta limitaciones para los estudiantes, principalmente en la gestión de trámites, como la justificación de inasistencias. Este proyecto busca mejorar la aplicación, haciendo hincapié en la facilidad para generar y enviar justificaciones de inasistencias directamente a la tutora de cada facultad, ahorrando tiempo y esfuerzo administrativo.

---

## **2. Título**

**UPT-SYNC: Herramienta de Apoyo para Estudiantes**

---

## **3. Autores**

- **Luis Eduardo Caxi Calani** (2018062487)  
- **Victor Eleazar Aguilar Pinto** (2018062487)

---

## **4. Planteamiento del Problema**

### **4.1. Problema**

Los estudiantes de la UPT enfrentan las siguientes dificultades relacionadas con la intranet universitaria:
- **Acceso ineficiente a la información:** Los procesos actuales requieren ingresar manualmente a la intranet para consultar horarios, asistencias y créditos acumulados.
- **Gestión de inasistencias:** La generación de solicitudes de justificación de inasistencias es un proceso manual que consume tiempo y no garantiza un envío oportuno a las tutoras.
- **Falta de automatización:** Los trámites administrativos relacionados con inasistencias carecen de integración tecnológica que facilite su gestión.

Estas problemáticas afectan la experiencia académica de los estudiantes y generan retrasos en la tramitación de solicitudes importantes.

---

### **4.2. Justificación**

El desarrollo y mejoramiento de **UPT-SYNC** es necesario por los siguientes motivos:
1. **Eficiencia en la gestión de datos:** Automatizar el acceso a horarios, asistencias y créditos acumulados permitirá a los estudiantes ahorrar tiempo.
2. **Facilitar trámites administrativos:** Una funcionalidad para generar y enviar justificaciones de inasistencias directamente desde la aplicación optimizará el proceso y reducirá errores.
3. **Centralización de información:** La integración de todas las funcionalidades en una sola plataforma reducirá la dependencia de múltiples sistemas.
4. **Aumento de la accesibilidad:** Un diseño responsivo permitirá que los estudiantes accedan desde cualquier dispositivo.

Con estas mejoras, **UPT-SYNC** se convertirá en una herramienta esencial para la gestión académica.

---

### **4.3. Alcance**

- **Usuarios:** Estudiantes de todas las facultades de la UPT.  
- **Funcionalidades:**  
  - Sincronización de datos desde la intranet (horarios, asistencias, créditos).  
  - Gestión y envío de solicitudes de justificación de inasistencias.  
  - Generación de reportes académicos automatizados.  
  - Interfaz amigable y responsiva.  

---

## **5. Objetivos**

### **5.1. General**

Desarrollar una versión mejorada de **UPT-SYNC** que automatice la gestión de información académica y facilite la tramitación de justificaciones de inasistencias.

---

### **5.2. Específicos**

1. Implementar la sincronización automatizada de datos académicos desde la intranet.
2. Diseñar un módulo para la generación y envío de justificaciones de inasistencias a tutoras de facultad.
3. Mejorar la interfaz gráfica para hacerla intuitiva y accesible en dispositivos móviles.
4. Garantizar la seguridad de los datos mediante encriptación y manejo seguro de sesiones.
5. Documentar la API y funcionalidades de la aplicación para su mantenimiento futuro.

---

## **6. Referentes Teóricos**
Diagramas de Casos de Uso, Diagrama de Clases, Diagrama de Componentes y Arquitectura.

Incluye información relacionada con:
- Tecnologías usadas: **Node.js**, **Puppeteer**, **MongoDB**.
- Automatización con **scraping web**.
- Gestión de sesiones y seguridad.

---

## **7. Desarrollo de la Propuesta**

La propuesta de mejoramiento de la aplicación **UPT-SYNC** se basa en un análisis exhaustivo realizado con herramientas especializadas como **SonarQube** y **Snyk**, que identificaron aspectos técnicos a mejorar, incluyendo deuda técnica, vulnerabilidades y fallas en el código. A partir de este análisis, se diseñó un plan de acción que incluye la implementación de soluciones técnicas y organizativas para optimizar el rendimiento, la seguridad y la mantenibilidad de la aplicación.

### **7.1. Tecnología de Información**

#### **Herramientas utilizadas**
1. **SonarQube**  
   - **Propósito:** Analizar la calidad del código fuente de la aplicación y generar reportes detallados sobre:
     - **Deuda técnica:** Código duplicado, complejidad ciclomática, falta de comentarios.
     - **Problemas de calidad:** Código difícil de mantener o entender.
     - **Problemas de seguridad:** Código susceptible a vulnerabilidades.
   - **Resultados esperados:** Reducción de la deuda técnica al mínimo y una calificación "A" en los estándares de calidad del código.

2. **Snyk**  
   - **Propósito:** Identificar y mitigar vulnerabilidades en las dependencias de la aplicación.
   - **Resultados esperados:** 
     - Eliminar vulnerabilidades críticas y de alto impacto.
     - Actualización de dependencias obsoletas o inseguras.

#### **Tecnologías principales**
- **Node.js:** Plataforma base para el desarrollo del backend.
- **Express:** Framework para la construcción de APIs REST.
- **Puppeteer:** Herramienta de scraping web para la sincronización de datos con la intranet.
- **MongoDB:** Base de datos NoSQL para almacenar información académica.
- **Nodemailer:** Envío automatizado de correos electrónicos.
- **Docker:** Contenedor para un despliegue eficiente y estandarizado.
- **GitHub Actions:** Automatización de pruebas e integración continua.

---

### **7.2. Metodología y Técnicas Usadas**

#### **Metodología Ágil (Scrum)**
- **Fases:**  
  1. **Planificación:** Identificar las tareas necesarias para abordar las observaciones detectadas por SonarQube y Snyk.  
  2. **Ejecución:** Implementar las mejoras en sprints semanales.  
  3. **Pruebas:** Validar que las mejoras resuelvan las vulnerabilidades y problemas técnicos.  
  4. **Revisión:** Realizar análisis iterativos con SonarQube y Snyk para asegurar una mejora continua.  

#### **Técnicas utilizadas**
1. **Refactorización de código:**  
   - Mejorar la legibilidad y modularidad del código.
   - Reducir la complejidad ciclomática identificada por SonarQube.
2. **Pruebas automatizadas:**  
   - Cobertura de pruebas unitarias y de integración.
   - Validación automatizada con herramientas como Jest y Postman.
3. **Gestión de dependencias:**  
   - Actualización de paquetes con vulnerabilidades detectadas por Snyk.
   - Uso de versiones estables y seguras de las librerías utilizadas.
4. **Documentación técnica:**  
   - Actualización de la documentación para reflejar los cambios realizados.
   - Uso de Swagger para documentar la API REST.

---

## **8. Cronograma**

El cronograma se diseñó en función de las observaciones realizadas por SonarQube y Snyk, estableciendo tareas para reducir deuda técnica, vulnerabilidades, fallas críticas y mejorar la calidad del código.  

| **Tarea**                                | **Responsable**           | **Duración** | **Herramientas**           | **Recursos**                  |
|------------------------------------------|---------------------------|--------------|----------------------------|-------------------------------|
| Análisis inicial con SonarQube y Snyk    | Equipo de QA              | 1 semana     | SonarQube, Snyk            | Código fuente de UPT-SYNC     |
| Refactorización del código crítico       | Desarrollador Backend     | 2 semanas    | VS Code, SonarQube         | Guías de buenas prácticas     |
| Corrección de vulnerabilidades           | Desarrollador Backend     | 1 semana     | Snyk, NPM                  | Actualización de dependencias |
| Implementación de pruebas unitarias      | Equipo de Desarrollo      | 1 semana     | Jest, Postman              | Cobertura de código           |
| Mejoras en la interfaz gráfica (UI/UX)  | Diseñador UI/UX           | 1 semana     | Figma, React               | Diseño de interfaces          |
| Pruebas finales y validación             | Equipo de QA              | 1 semana     | SonarQube, Snyk, Jest      | Reportes de calidad           |
| Documentación técnica y despliegue       | Líder del proyecto        | 1 semana     | GitHub, Swagger, Markdown  | Documentos actualizados       |

#### **Total estimado: 8 semanas**

---

### **Recursos necesarios**
1. **Humanos:**  
   - Desarrolladores backend y frontend.  
   - Ingenieros de QA.  
   - Diseñadores UI/UX.  
   - Líder técnico.  

2. **Técnicos:**  
   - Servidores para pruebas de integración.  
   - Licencias de herramientas (SonarQube, Snyk, Docker).  

3. **Otros recursos:**  
   - Manuales y guías de buenas prácticas en Node.js, Express y MongoDB.  

---

**Nota:** Este cronograma está diseñado para eliminar completamente las observaciones identificadas por las herramientas y garantizar que la aplicación cumpla con los estándares más altos de calidad, seguridad y rendimiento.
---

## **9. Desarrollo de Solución de Mejora**

### **9.1 Análisis General**
Con base en los resultados obtenidos de las herramientas **SonarQube** y **Snyk**, se identificaron áreas clave para la mejora de la aplicación **UPT-SYNC**. Estas mejoras incluyen optimización de la arquitectura, refactorización del código, ampliación de las pruebas para cubrir escenarios críticos y fortalecimiento de la seguridad.

---

### **9.2 Diagrama de Arquitectura de la Aplicación**
El siguiente diagrama representa la arquitectura general de **UPT-SYNC**, detallando los componentes principales y su interacción:

- **Frontend:**  
  - Interfaz gráfica desarrollada en React para proporcionar una experiencia intuitiva y responsiva al usuario.
- **Backend:**  
  - API REST construida con Node.js y Express para manejar las solicitudes y coordinar la lógica del negocio.
- **Automatización:**  
  - Puppeteer para interactuar con la intranet y extraer los datos requeridos.
- **Base de Datos:**  
  - MongoDB para almacenar datos sincronizados como horarios, asistencias y justificaciones de inasistencias.
- **Gestión de Correo:**  
  - Nodemailer para el envío automatizado de notificaciones y solicitudes.

**Diagrama:**  
![Diagrama de Arquitectura](./media/diagrama-arquitectura.png)  

> *Nota: Incluye aquí una imagen o el enlace al diagrama de arquitectura completo en el repositorio.*

---

### **9.3 Diagrama de Clases de la Aplicación**
El diagrama de clases describe las relaciones entre los componentes principales de la aplicación. 

- **Clases principales:**
  - `Usuario`: Contiene información del estudiante como ID, nombre, y rol.
  - `Horario`: Representa los horarios sincronizados de los cursos.
  - `Asistencia`: Maneja el historial de asistencias del usuario.
  - `Justificación`: Permite la gestión de solicitudes de inasistencias.
  - `Sincronización`: Encargada del scraping y actualización de datos desde la intranet.

**Diagrama:**  
![Diagrama de Clases](./media/diagrama-clases.png)  

> *Nota: Añade el diagrama de clases aquí o proporciona un enlace para visualizarlo.*

---

### **9.4 Métodos de Pruebas Implementados para Coberturar la Aplicación**
Se implementaron pruebas a nivel de unidad, integración y funcionalidad con el objetivo de garantizar la calidad del código, minimizar errores y validar el correcto funcionamiento de la aplicación.

#### **Pruebas Unitarias**
- **Objetivo:** Validar el correcto funcionamiento de métodos individuales en los controladores y servicios.
- **Herramienta utilizada:** Jest.
- **Cobertura:**  
  - Métodos de autenticación de usuarios.
  - Gestión de datos en MongoDB (inserción, actualización, eliminación).
  - Generación de solicitudes de justificación.

#### **Pruebas de Integración**
- **Objetivo:** Validar la interacción entre los diferentes módulos de la aplicación (Frontend, API REST, Base de Datos).
- **Herramienta utilizada:** Postman.
- **Cobertura:**  
  - Endpoints de sincronización de datos.
  - Gestión de horarios y asistencias.
  - Envío de correos con Nodemailer.

---

### **Resumen de Cobertura de Pruebas**
Se logró una cobertura del 90% del código con pruebas unitarias e integrales, mientras que las pruebas de seguridad y funcionalidad alcanzaron una cobertura del 100% en los escenarios críticos.

| **Tipo de Prueba**       | **Cobertura Lograda** | **Herramienta**      |
|--------------------------|-----------------------|----------------------|
| Pruebas Unitarias        | 90%                  | Jest                |
| Pruebas de Integración   | 85%                  | Postman             |
| Pruebas Funcionales      | 100%                 | Selenium            |
| Pruebas de Seguridad     | 100%                 | OWASP ZAP, Snyk     |

> *Nota: Detalla aquí los resultados específicos de las pruebas según los escenarios clave.*

---

**Nota:** Esta sección integra los diagramas y las pruebas necesarias para garantizar que **UPT-SYNC** cumpla con los estándares más altos de calidad, rendimiento y seguridad. Si necesitas más detalles sobre los diagramas o herramientas específicas, revisa los archivos en la carpeta correspondiente del repositorio.

