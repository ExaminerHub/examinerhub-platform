# ExaminerHub

**A full-stack examination operations platform designed to simplify the planning and delivery of Cambridge English speaking examination sessions.**

ExaminerHub is an independently developed software project inspired by real-world examination workflows and operational challenges experienced by examiners and examination centres.

The goal is to replace fragmented emails, manually edited documents and error-prone scheduling processes with a single, reliable platform for administrators and examiners.

> **Status:** 🚧 Active development

---

## The Problem

Speaking examination sessions involve a surprising amount of operational information:

* Where is the examination taking place?
* What time must the examiner arrive?
* What time does the first candidate start?
* Who is the partner examiner?
* Is the partner examiner on-site or remote?
* Which exam levels are being examined?
* How many pairs and trios are scheduled?
* Which room is being used?
* Is there a video-conferencing link for a remote examiner?

Much of this information can arrive through emails, PDFs and manually maintained documents. When information is incomplete, inconsistent or changed manually, mistakes can have a direct impact on an examination session.

ExaminerHub is being built to provide a clearer and more reliable workflow.

---

## Current Functionality

The application currently supports:

* Examination centres
* Examination rooms
* Speaking examination sessions
* Session dates
* Examiner arrival times
* First-candidate start times
* Expected finish times
* Partner examiner information
* On-site and remote examiner status
* Video-conferencing links for remote sessions
* Multiple exam levels within a session
* Pair and trio allocations
* Session notes
* Persistent storage using SQL Server
* REST API access to session information
* Seeded development/test data

---

## Architecture

ExaminerHub uses a layered .NET architecture:

```text
ExaminerHub
│
├── ExaminerHub.Api
│   └── REST API / HTTP endpoints
│
├── ExaminerHub.Application
│   └── Application services and interfaces
│
├── ExaminerHub.Domain
│   └── Core domain entities and business model
│
└── ExaminerHub.Infrastructure
    └── Entity Framework Core, repositories and database access
```

The application follows separation-of-concerns principles so that the domain model, application logic, persistence and API layers can evolve independently.

---

## Technology Stack

**Backend**

* C#
* .NET 10
* ASP.NET Core
* REST APIs

**Data**

* Entity Framework Core
* SQL Server
* EF Core migrations

**Frontend**

* Blazor *(in development)*

**Development**

* Visual Studio
* Git
* GitHub
* Postman

---

## Example Session Data

A session can contain operational information such as:

```text
Centre: Kensington Site
Location: Murcia
Room: Room 1

Arrival: 09:00
First candidate: 09:30
Expected finish: 14:10

Partner examiner: Gemma
Partner location: On-site

Examinations:
FCE FS — 3 pairs, 1 trio
PET FS — 9 pairs
PET — 4 pairs
```

This information is exposed through the application's REST API and will ultimately be presented through a mobile-friendly examiner dashboard.

---

## Planned Examiner Dashboard

The examiner-facing application is being designed around the information an examiner needs immediately before and during a session.

Planned functionality includes:

* 📍 Venue and room information
* 🗺️ One-tap navigation to the examination venue
* 🕘 Clearly highlighted arrival time
* 🎤 First-candidate time
* ⏱️ Arrival countdown
* 👤 Partner examiner details
* 🌐 Remote/on-site examiner status
* 🎥 One-click access to remote examination links
* 🎓 Exam levels and candidate groupings
* 📝 Session notes
* ⚠️ Important session alerts

The interface is being designed mobile-first because examiners will frequently access this information while travelling to or arriving at a venue.

---

## Planned Administrator Portal

A future administrative interface will allow examination centres to:

* Create examination sessions
* Manage centres and rooms
* Assign examiners
* Configure on-site and remote examiner arrangements
* Define examination levels and candidate groupings
* Upload examination timetable documents
* Validate session information before distribution
* Automatically provide examiners with the information relevant to their session

---

## PDF Timetable Import

One of the major planned features is document-assisted session creation.

Instead of administrators repeatedly transferring timetable information manually, the intended workflow is:

```text
Upload timetable PDF
        ↓
Extract session information
        ↓
Validate extracted data
        ↓
Administrator reviews/corrects
        ↓
Create ExaminerHub session
        ↓
Examiner receives structured session information
```

The administrator will remain responsible for confirming the extracted information before it becomes part of a live session.

---

## Future Integration

The architecture is being designed so that external examination-management APIs could potentially be integrated in the future where authorised API access is available.

PDF/document import provides an interim workflow while direct integrations are unavailable.

---

## Project Goals

ExaminerHub is intended to explore how software can:

1. Reduce manual administration.
2. Reduce transcription and scheduling errors.
3. Give examiners one reliable source of session information.
4. Make remote examination arrangements easier to access.
5. Improve visibility of arrival and start times.
6. Turn existing examination documents into structured data.
7. Provide examination centres with a more consistent operational workflow.

---

## Development Roadmap

### Phase 1 — Core Platform

* [x] Domain model
* [x] SQL Server persistence
* [x] Entity Framework Core
* [x] Repository layer
* [x] Application service layer
* [x] Sessions REST API
* [x] Multi-level exam assignments

### Phase 2 — Examiner Experience

* [ ] Mobile-first examiner dashboard
* [ ] Session overview
* [ ] Navigation links
* [ ] Remote examiner links
* [ ] Arrival countdown
* [ ] Session alerts

### Phase 3 — Administration

* [ ] Administrator dashboard
* [ ] Centre management
* [ ] Examiner management
* [ ] Session creation
* [ ] Examiner assignment
* [ ] Timetable management

### Phase 4 — Automation

* [ ] PDF timetable upload
* [ ] Structured data extraction
* [ ] Validation workflow
* [ ] Conflict/error detection
* [ ] Automated document generation

### Phase 5 — Integration

* [ ] Authentication and authorisation
* [ ] Notifications
* [ ] External API integration where available
* [ ] Production deployment

---

## Why I Built ExaminerHub

ExaminerHub originated from observing how much important examination information is still communicated through combinations of emails, PDFs, manually edited templates and last-minute updates.

The project applies software engineering to a real operational problem rather than starting with a technology and searching for a use case.

It is also an ongoing portfolio project demonstrating practical experience with:

* C# and .NET development
* Object-oriented design
* Layered application architecture
* REST API design
* Entity Framework Core
* Relational database modelling
* Dependency injection
* Repository and service patterns
* Git/GitHub workflows
* API testing with Postman
* Requirements analysis
* Full-stack application development

---

## Repository Structure

ExaminerHub is being developed across several repositories within the ExaminerHub GitHub organisation:

* **examinerhub-platform** — Core application and platform
* **examinerhub-api** — API-related development
* **examinerhub-docs** — Product documentation and requirements
* **examinerhub-design** — Product and interface design

---

## Disclaimer

ExaminerHub is an independent software development project. It is not an official Cambridge University Press & Assessment product and is not affiliated with or endorsed by Cambridge English.
