# ExaminerHub

[🇬🇧 English](README.md) | 🇪🇸 **Español**

**Una plataforma full-stack para la gestión de operaciones de exámenes, diseñada para simplificar la planificación y realización de sesiones de Speaking de Cambridge English.**

ExaminerHub es un proyecto de software desarrollado de forma independiente e inspirado en flujos de trabajo reales y en problemas operativos habituales de examinadores y centros de examen.

El objetivo es sustituir correos dispersos, documentos editados manualmente y procesos de planificación propensos a errores por una única plataforma fiable para administradores y examinadores.

> **Estado:** 🚧 En desarrollo activo

---

## El problema

Las sesiones de Speaking requieren gestionar una cantidad considerable de información operativa:

* ¿Dónde se realiza el examen?
* ¿A qué hora debe llegar el examinador?
* ¿A qué hora empieza el primer candidato?
* ¿Quién es el examinador compañero?
* ¿El compañero está presencialmente o en remoto?
* ¿Qué niveles se examinan?
* ¿Cuántas parejas y tríos hay programados?
* ¿Qué aula se utiliza?
* ¿Existe un enlace de videoconferencia para un examinador remoto?

Gran parte de esta información puede llegar mediante correos electrónicos, PDFs y documentos mantenidos manualmente.

Cuando la información está incompleta, es inconsistente o se modifica manualmente, los errores pueden afectar directamente al desarrollo de una sesión de examen.

ExaminerHub se está desarrollando para proporcionar un flujo de trabajo más claro, estructurado y fiable.

---

## Funcionalidad actual

Actualmente la aplicación permite trabajar con:

* Centros de examen
* Aulas
* Sesiones de Speaking
* Fechas de sesión
* Horas de llegada del examinador
* Hora del primer candidato
* Hora prevista de finalización
* Información del examinador compañero
* Estado presencial o remoto
* Enlaces de videoconferencia para sesiones remotas
* Múltiples niveles dentro de una misma sesión
* Distribución de parejas y tríos
* Notas de sesión
* Persistencia de datos mediante SQL Server
* Acceso a la información mediante REST API
* Datos de desarrollo y prueba

---

## Arquitectura

ExaminerHub utiliza una arquitectura .NET por capas:

```text
ExaminerHub
│
├── ExaminerHub.Api
│   └── REST API / endpoints HTTP
│
├── ExaminerHub.Application
│   └── Servicios de aplicación e interfaces
│
├── ExaminerHub.Domain
│   └── Entidades de dominio y modelo de negocio
│
└── ExaminerHub.Infrastructure
    └── Entity Framework Core, repositorios y acceso a datos
```

La aplicación aplica separación de responsabilidades para que el dominio, la lógica de aplicación, la persistencia y la API puedan evolucionar de forma independiente.

---

## Stack tecnológico

**Backend**

* C#
* .NET 10
* ASP.NET Core
* REST APIs

**Datos**

* Entity Framework Core
* SQL Server
* Migraciones de EF Core

**Frontend**

* Blazor *(en desarrollo)*

**Herramientas de desarrollo**

* Visual Studio
* Git
* GitHub
* Postman

---

## Ejemplo de una sesión

Una sesión puede contener información operativa como:

```text
Centro: Kensington Site
Ubicación: Murcia
Aula: Room 1

Llegada: 09:00
Primer candidato: 09:30
Finalización prevista: 14:10

Examinador compañero: Gemma
Modalidad: Presencial

Exámenes:
FCE FS — 3 parejas, 1 trío
PET FS — 9 parejas
PET — 4 parejas
```

Esta información se expone mediante la REST API y posteriormente se mostrará en un dashboard optimizado para examinadores.

---

## Dashboard del examinador

La interfaz del examinador se está diseñando alrededor de la información que necesita consultar inmediatamente antes y durante una sesión.

Funcionalidad prevista:

* 📍 Información de sede y aula
* 🗺️ Navegación con un solo clic hasta el centro
* 🕘 Hora de llegada claramente destacada
* 🎤 Hora del primer candidato
* ⏱️ Cuenta atrás hasta la hora de llegada
* 👤 Información del examinador compañero
* 🌐 Estado presencial/remoto
* 🎥 Acceso directo a enlaces de videoconferencia
* 🎓 Niveles y grupos de candidatos
* 📝 Notas de sesión
* ⚠️ Alertas importantes

La interfaz se está diseñando siguiendo un enfoque **mobile-first**, ya que los examinadores consultarán frecuentemente esta información desde el móvil al desplazarse o llegar a una sede.

---

## Portal de administración

Una futura interfaz administrativa permitirá a los centros:

* Crear sesiones de examen
* Gestionar centros y aulas
* Asignar examinadores
* Configurar examinadores presenciales y remotos
* Definir niveles y grupos de candidatos
* Subir documentos de planificación
* Validar la información antes de distribuirla
* Proporcionar automáticamente a cada examinador la información relevante para su sesión

---

## Importación de horarios desde PDF

Una de las principales funcionalidades previstas es la creación asistida de sesiones a partir de documentos.

En lugar de transferir manualmente información de horarios una y otra vez, el flujo previsto será:

```text
Subir PDF del horario
        ↓
Extraer información de la sesión
        ↓
Validar los datos extraídos
        ↓
Revisión/corrección por parte del administrador
        ↓
Crear sesión en ExaminerHub
        ↓
El examinador recibe información estructurada
```

El administrador seguirá siendo responsable de confirmar la información antes de que forme parte de una sesión activa.

---

## Integraciones futuras

La arquitectura se está diseñando para permitir futuras integraciones con APIs externas de gestión de exámenes si se dispone de acceso autorizado.

Mientras no exista acceso directo a dichas APIs, la importación mediante PDF ofrece un flujo de trabajo intermedio práctico.

---

## Objetivos del proyecto

ExaminerHub pretende explorar cómo el software puede:

1. Reducir trabajo administrativo manual.
2. Reducir errores de transcripción y planificación.
3. Proporcionar al examinador una única fuente fiable de información.
4. Facilitar la gestión de examinadores remotos.
5. Mejorar la visibilidad de las horas de llegada y comienzo.
6. Convertir documentación existente en datos estructurados.
7. Proporcionar a los centros un flujo de trabajo operativo más consistente.

---

## Roadmap de desarrollo

### Fase 1 — Plataforma principal

* [x] Modelo de dominio
* [x] Persistencia con SQL Server
* [x] Entity Framework Core
* [x] Capa de repositorios
* [x] Capa de servicios de aplicación
* [x] REST API de sesiones
* [x] Múltiples niveles por sesión

### Fase 2 — Experiencia del examinador

* [ ] Dashboard mobile-first
* [ ] Vista de sesión
* [ ] Enlaces de navegación
* [ ] Enlaces para examinadores remotos
* [ ] Cuenta atrás hasta la llegada
* [ ] Alertas de sesión

### Fase 3 — Administración

* [ ] Dashboard de administración
* [ ] Gestión de centros
* [ ] Gestión de examinadores
* [ ] Creación de sesiones
* [ ] Asignación de examinadores
* [ ] Gestión de horarios

### Fase 4 — Automatización

* [ ] Subida de horarios en PDF
* [ ] Extracción estructurada de datos
* [ ] Flujo de validación
* [ ] Detección de conflictos y errores
* [ ] Generación automática de documentos

### Fase 5 — Integración

* [ ] Autenticación y autorización
* [ ] Notificaciones
* [ ] Integraciones externas cuando estén disponibles
* [ ] Despliegue en producción

---

## Por qué desarrollé ExaminerHub

ExaminerHub surgió al observar la cantidad de información importante de una sesión de examen que todavía se comunica mediante una combinación de correos electrónicos, PDFs, plantillas editadas manualmente y cambios de última hora.

El proyecto aplica ingeniería de software a un problema operativo real, en lugar de comenzar por una tecnología y buscar posteriormente un caso de uso.

También es un proyecto de portfolio en evolución que demuestra experiencia práctica con:

* Desarrollo con C# y .NET
* Diseño orientado a objetos
* Arquitectura por capas
* Diseño de REST APIs
* Entity Framework Core
* Modelado de bases de datos relacionales
* Inyección de dependencias
* Patrones Repository y Service
* Flujo de trabajo con Git y GitHub
* Pruebas de API con Postman
* Análisis de requisitos
* Desarrollo full-stack

---

## Estructura de repositorios

ExaminerHub se desarrolla en varios repositorios dentro de la organización de GitHub ExaminerHub:

* **examinerhub-platform** — Aplicación principal y plataforma
* **examinerhub-api** — Desarrollo relacionado con la API
* **examinerhub-docs** — Documentación de producto y requisitos
* **examinerhub-design** — Diseño de producto e interfaz

---

## Aviso

ExaminerHub es un proyecto independiente de desarrollo de software.

No es un producto oficial de Cambridge University Press & Assessment y no está afiliado ni respaldado por Cambridge English.
