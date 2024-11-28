<center>

[comment]: <img src="./media/media/image1.png" style="width:1.088in;height:1.46256in" alt="escudo.png" />

![./media/media/image1.png](./media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERIA**

**Escuela Profesional de Ingeniería de Sistemas**

**Proyecto *RUMI***

Curso: *Calidad y Pruebas de Software*

Docente: *Ing. Patrick Jose CUADROS QUIROGA*

Integrantes:<br>
<b>CAXI CALANI Luis Eduardo (2018062487)</b><br>
<b>AGUILAR PINTO Victor Eleazar (2018062487)</b><br>
<b>CHATA CHOQUE Brant Antony (2020067577)</b>


**Tacna – Perú**

***2024***

</center>
<div style="page-break-after: always; visibility: hidden">\pagebreak</div>


|CONTROL DE VERSIONES||||||
| :-: | :- | :- | :- | :- | :- |
|Versión|Hecha por|Revisada por|Aprobada por|Fecha|Motivo|
|1\.0|AC VA LC|PCQ|PCQ|17/09/2024|Versión Inicial|
|2\.0|AC VA LC|PCQ|PCQ|21/09/2024|Segunda Version|
|3\.0|AC VA LC|PCQ|PCQ|03/10/2024|Versión Final|

<div style="page-break-after: always; visibility: hidden"></div>

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


<div style="page-break-after: always; visibility: hidden"></div>

**<u>Tema: Mejoramiento de la Aplicación RUMI</u>**

1. <span id="_Toc52661346" class="anchor"></span>**Antecedentes o introducción**
    <p>La auditoría de la aplicación RUMI se ha realizado con el objetivo de identificar vulnerabilidades de seguridad y problemas de calidad de código. Para ello, se utilizaron herramientas de análisis como Snyk y SonarQube, que permitieron detectar fallos críticos y mejorar la seguridad de la aplicación.</p>

2. <span id="_Toc52661347" class="anchor"></span>**Titulo**
    <p><b>Auditoría y Mejoramiento de la Seguridad en la Aplicación RUMI usando Snyk y SonarQube</b></p>

3. <span id="_Toc52661348" class="anchor"></span>**Autores**

4. <span id="_Toc52661349" class="anchor"></span>**Planteamiento del problema**

    4.1. <span id="_Toc52661350" class="anchor"></span>Problema
    <p>La aplicación RUMI presenta vulnerabilidades que comprometen la seguridad de los usuarios y el rendimiento del sistema. Estas incluyen la falta de validación de tokens anti-forgery, el uso de algoritmos de hash débiles, y versiones obsoletas de bibliotecas externas.</p>

    4.2. <span id="_Toc52661351" class="anchor"></span>Justificación
    <p>La seguridad de las aplicaciones es un factor clave para garantizar la protección de los datos de los usuarios y la estabilidad del sistema. Esta auditoría es esencial para reducir riesgos y asegurar el cumplimiento de los estándares de seguridad en la aplicación RUMI.</p>

    4.3. <span id="_Toc52661352" class="anchor"></span>

5. <span id="_Toc52661356" class="anchor"></span>**Objetivos**

    5.1. General
    <p>Mejorar la seguridad y la calidad de código de la aplicación RUMI mediante el análisis de vulnerabilidades y la implementación de mejoras recomendadas por las herramientas de análisis Snyk y SonarQube.</p>

    5.8. Especifico
    <ul>
        <li>Detectar y corregir vulnerabilidades en el código y dependencias con Snyk.</li>
        <li>Mejorar la calidad del código mediante el análisis estático de SonarQube.</li>
        <li>Implementar medidas para reducir la deuda técnica de la aplicación.</li>
    </ul>

6. <span id="_Toc52661357" class="anchor"></span>**Referentes teóricos**

   ## 6.1. Diagramas de Casos de Uso
   
    ![casosUso](https://github.com/user-attachments/assets/c644460c-eb70-4d88-aa5a-776af2cada2f)
    <div style="text-align: center;">Figura 6.1: Diagrama de Casos de Uso</div>


   ## 6.2. Diagrama de Clases BD

   ![DiagramaClases](https://github.com/user-attachments/assets/b85268b1-edd6-4e26-a67a-ee0935095a0f)
   <div style="text-align: center;">Figura 6.2: Diagrama de Clases BD</div>

   ## 6.2. Diagrama de Clases

   ![ClasesMetodos drawio](https://github.com/user-attachments/assets/52b93c56-813a-4042-9989-ec5de4349bed)
   <div style="text-align: center;">Figura 6.2: Diagrama de Clases BD</div>

   ## 6.3. Diagrama de Componentes.

   ![Componentes](https://github.com/user-attachments/assets/f46b0faa-9311-4e62-9706-a9a22f2f3fde)
   <div style="text-align: center;">Figura 6.2: Diagrama de Componentes</div>
   
   ## 6.4. Diagrama de Arquitectura.
   
   ![Arquitectura](https://github.com/user-attachments/assets/52f06cef-edd8-4f81-9822-b8b2e0fc671b)
   <div style="text-align: center;">Figura 6.2: Diagrama de Arquitectura</div>

8. Desarrollo de la propuesta
    <p>El análisis de la aplicación RUMI fue llevado a cabo utilizando las herramientas Snyk y SonarQube, las cuales detectaron varias áreas de mejora, tanto en la seguridad como en la calidad del código.</p>

    7.1.   Tecnología de información 
    <p><b>Snyk:</b> Esta herramienta se utilizó para identificar vulnerabilidades en las dependencias de código abierto y en el código fuente de la aplicación. Se encontraron problemas como el uso de hash débil (MD5) y dependencias obsoletas.</p>
    <img src="media/Snyk.png" alt="Resultados del análisis de SonarQube" style="width:600px;">

    <p><b>SonarQube:</b> Herramienta de análisis estático utilizada para evaluar la calidad del código. Detectó problemas de duplicación de código y alta complejidad ciclomática en algunos módulos clave.</p>
        <p><b>PASOS A SEGUIR</b></p>
            <li><b>Primer paso: Configuración del proyecto para SonarQube</b> En este paso, configuramos un nuevo proyecto en SonarQube. Asignamos un nombre para mostrar y una clave de proyecto que será utilizada para identificar de manera única este proyecto en SonarQube. También configuramos la rama principal del proyecto.</li>
            ![image](https://github.com/user-attachments/assets/7c99c00c-d051-471c-8c7b-16a3787d268c)
            <img src="media/paso1.png" alt="Configuracion del proyecto para SonarQube" style="width:600px;">
            <li><b>Segundo paso</b> Este paso permite definir cómo SonarQube tratará el código nuevo dentro del proyecto. Esto es esencial para seguir la metodología de "Clean as You Code", donde el código nuevo se considera de manera especial para que mantenga altos estándares de calidad.</li>
            <img src="media/pasodos.png" alt="" style="width:600px;">
            <li><b>Tercer paso:</b>En este paso, seleccionamos el método de análisis que será utilizado para escanear el código de tu proyecto. SonarQube ofrece diversas opciones para integrarse con plataformas de CI/CD, pero en este caso se ha seleccionado la opción Locally para hacer pruebas locales del análisis.</li>
            <img src="media/pasotres.png" alt="" style="width:600px;">
            <li><b>Cuarto paso:</b>Generamos un Token de Proyecto para autenticar las ejecuciones de SonarScanner en este proyecto. Este token será utilizado para identificar el proyecto al hacer los análisis.</li>
            <img src="media/pasocuatro.png" alt="" style="width:600px;">
            <li><b>Quinto paso:</b>Una vez generado, SonarQube mostrará el token que deberá ser utilizado en los análisis del proyecto. Este token es sensible y debe mantenerse privado.
            -CalidadRumi: sqp_71f05de7adf9a946a7f69dd14e457182da8b4568</li>
            <img src="media/pasocinco.png" alt="" style="width:600px;">
            <li><b>Sexto paso:</b>Se configura la variable de entorno que apunta a la ruta donde está instalado SonarScanner en el sistema. Esto es necesario para que los comandos de SonarScanner se puedan ejecutar desde cualquier parte del sistema.</li>
            <img src="media/pasoseis.png" alt="" style="width:600px;">
            <li><b>Septimo paso:</b>En este paso, ejecutamos el análisis del proyecto utilizando SonarScanner for .NET Framework. El análisis local revisa el código y lo sube a SonarQube para generar los reportes de calidad y seguridad.</li>
            <img src="media/pasosiete.png" alt="" style="width:600px;">
            <li><b>Octavo paso:</b>El resultado de la compilación y el análisis final es procesado por SonarScanner, el cual sube los resultados a SonarQube para su revisión.</li>
            <img src="media/pasoocho.png" alt="" style="width:600px;">
            <li><b>Noveno paso:</b>Si existen advertencias relacionadas con la configuración o análisis, SonarScanner las mostrará en la terminal.</li>
            <img src="media/pasonueve.png" alt="" style="width:600px;">
            <li><b>Decimo paso:</b>El análisis de SonarScanner se completa y los resultados son enviados a SonarQube. A partir de aquí, puedes revisar los resultados en la interfaz web de SonarQube.</li>
            <img src="media/pasodiez.png" alt="" style="width:600px;">

    7.2.   Metodología, técnicas usadas
    <p>El análisis se realizó en varias fases:</p>
    <ul>
        <li><b>Fase 1:</b> Análisis inicial con Snyk para identificar vulnerabilidades de seguridad en las dependencias y el código.</li>
        <img src="media/fase1.png" alt="" style="width:600px;">
        <li><b>Vulnerabilidad Detectada: Validación de Tokens Anti-Forgery Deshabilitada en Acción MVC</b></li>
        <img src="media/fase1.1.png" alt="" style="width:600px;">
        <li><b>Vulnerabilidad Detectada: Uso de Algoritmo de Hash MD5 Inseguro para Contraseñas</b></li>
        <img src="media/fase1.2.png" alt="" style="width:600px;">
        <li><b>Vulnerabilidad Detectada: Uso Inseguro de Plugin de jQuery por Entrada No Saneada</b></li>
        <img src="media/fase1.3.png" alt="" style="width:600px;">
        <li><b>Fase 2:</b> Análisis estático con SonarQube para detectar problemas de calidad, como código duplicado y alta complejidad.</li>
        <img src="media/Sonar.png" alt="Resultados del análisis de SonarQube" style="width:600px;">
        <li><b>Fase 3:</b> Implementación de mejoras y reanálisis de la aplicación para verificar que los problemas se resolvieran.</li>
    </ul>

9. Cronograma
    <p><b>Personas involucradas:</b> Equipo de desarrollo, equipo de seguridad.</p>
    <p><b>Tiempo:</b> Se estima que la corrección de todas las vulnerabilidades identificadas, así como la implementación de mejoras en la calidad del código, se completará en un periodo de 4 semanas.</p>
    <p><b>Recursos:</b> Las herramientas utilizadas incluyen Snyk, SonarQube y Visual Studio. Los desarrolladores deberán seguir las recomendaciones del análisis para realizar los cambios pertinentes.</p>
