# CivicConnect Project Engineering Document — PED v4.0

## Final Engineering Baseline — Milestone 4

**Project:** CivicConnect — Community Service Request Management Platform  
**Module:** SEN381 Software Engineering 381  
**Version:** v4.0  
**Status:** Finalisation draft — pending team review and approval  
**Final branch:** `feat/m4-finalisation-v2`  
**Final commit:** populate after the final M4 commit  
**Authors:** Christoffel Lombard (602390); Petrus Barend Wentzel (601201)

---

## 1. M4 Purpose

M4 closes the same CivicConnect project established in M1. It is not a new product phase. This document records the final repository state, M1 scope closure, M3 findings, quality position, technical debt, deployment decision and final conclusion.

The submitted M3 recording is retained as demonstration evidence. The current GitHub repository is the authoritative implementation baseline.

## 2. Final Product Baseline

The repository contains a C#/.NET 8 Windows Forms application with Presentation, Business Logic, Data Access and Models layers. SQL Server LocalDB is used for persistence. The implementation includes authentication, request creation, request search/filtering, lifecycle status changes, notifications, escalation strategies, domain-event infrastructure and a contractor adapter boundary.

The M3 recording presented release candidate `v3.0.0-RC1`, including the request loop, lifecycle machine, domain-event audit, adapter boundary, database safeguards, RTM and performance evidence.

## 3. M1 Scope Closure

| M1 commitment | Final status | Evidence-based conclusion |
|---|---|---|
| Request creation | PARTIAL | Title/category/location/priority are captured; current UI does not collect a non-empty description. |
| Controlled categories | MET | Category is selected from a controlled list. |
| Requester identity/status/history | PARTIAL | Username modifier and timestamp exist, but requester ownership/history are not fully represented. |
| Staff queue/filter/search/sort | PARTIAL | Search/category/status filtering exists; role responsibility and time sorting are incomplete. |
| Request detail/lifecycle history | PARTIAL | Details/status exist; durable lifecycle history is absent. |
| Assignment | NOT MET | No assignment persistence/workflow is present. |
| Controlled lifecycle | PARTIAL | Lifecycle rules exist; durable transition history is not present in the repository schema. |
| Action/comment/resolution notes | NOT MET | No persisted notes model exists. |
| Authorised resolve/close | PARTIAL | Lifecycle exists, but fine-grained role authorisation is incomplete. |
| Lifecycle history after closure | NOT MET | No durable history table exists. |
| Oversight activity view | MET | Dashboard metrics provide total/pending/in-progress/resolved-closed counts. |
| Open/overdue/resolved/closed view | PARTIAL | Status filtering exists; overdue rule is not implemented. |
| Category/status oversight | MET | Category and status filters exist. |
| Accountability/performance view | PARTIAL | Request ID, category, status, dates and modifier are available, but assignment/history are limited. |
| Rejection reason | NOT MET | No rejection workflow/reason field exists. |
| Requester isolation | NOT MET | Current queue is not restricted to requester-owned records. |

### Quantified functional scope

Using the M4 scoring values Met = 1, Partially = 0.5 and Not Met = 0 across the 20 M1 functional requirements:

- Met: 3
- Partially implemented: 9
- Not met: 8
- **Functional completion: 40%**

This does not meet the M4 80% target. The final document deliberately does not relabel incomplete committed functionality as out-of-scope.

## 4. M1 NFR Closure

| NFR | Status | Conclusion |
|---|---|---|
| NFR-001 Access control | PARTIAL | Authentication exists; fine-grained role/ownership enforcement is incomplete. |
| NFR-002 Privacy | PARTIAL | No production privacy/retention decision is evidenced. |
| NFR-003 Availability | PARTIAL | Production availability is not established. |
| NFR-004 Performance | PARTIAL | M3 reports 184 ms mean response time vs <500 ms target; benchmark artefact is not committed. |
| NFR-005 Usability | PARTIAL | Validation exists, but description capture is incomplete. |
| NFR-006 Accessibility | N/A | Current product is Windows Forms; M1 WCAG condition applied to later web content. |
| NFR-007 Reliability | NOT MET | Duplicate handling is not demonstrated. |
| NFR-008 Secure configuration | PARTIAL | Local configuration exists and SQL seed data contains demo credentials; production configuration is not established. |
| NFR-009 Auditability | PARTIAL | Domain-event audit logging exists, but durable lifecycle history is absent. |
| NFR-010 Maintainability | MET | Layered structure and controlled GitHub documentation/PR history exist. |
| NFR-011 Recoverability | NOT MET | No tested backup/recovery procedure is evidenced. |
| NFR-012 Observability | PARTIAL | Centralised application logging exists; production observability plan is incomplete. |

## 5. M3 Findings and Closure

The submitted M3 recording reports:

- release candidate `v3.0.0-RC1`;
- a full service-request loop;
- four-layer separation;
- sequential lifecycle transitions;
- domain-event audit handling;
- contractor adapter boundary;
- parameterized SQL, optimistic-concurrency and transaction-boundary safeguards;
- five release requirements traced to implementation and verification;
- 184 ms mean response time for 20 concurrent sessions against a <500 ms target;
- zero release blockers, while third-party endpoints remained mocked and cloud stress testing was deferred;
- 15 automated tests and a green GitHub Actions quality gate.

The current accessible repository confirms the layered structure, lifecycle service and adapter/domain-event components, but it does **not** contain a matching automated test project or committed performance benchmark artefact. M4 therefore treats those as submitted M3 evidence, not as reproducible final repository evidence.

## 6. M3 Defect / Limitation Closure

| ID | Finding | Final status |
|---|---|---|
| DEF-M4-001 | M3 automated-test artefact is not present in the accessible final repository | Open evidence gap |
| DEF-M4-002 | M3 performance benchmark artefact is not present in the accessible final repository | Open evidence gap |
| DEF-M4-003 | Durable lifecycle-history persistence is not present | Open implementation limitation |
| DEF-M4-004 | Requester ownership and fine-grained authorisation are incomplete | Open implementation limitation |
| DEF-M4-005 | Production recovery/configuration/operational evidence is incomplete | Open readiness limitation |

## 7. Technical Debt Closure

Retained debt:

1. requester ownership and role-specific access;
2. assignment persistence;
3. durable lifecycle history;
4. notes/rejection workflow;
5. reproducible automated regression tests;
6. reproducible performance benchmark evidence;
7. production backup/recovery;
8. production observability and configuration.

M4 records these items rather than silently implementing a new architecture or creating a new testing programme.

## 8. Deployment / Go-Live Decision

**FINAL DECISION: NO-GO FOR PRODUCTION.**

**Permitted state:** controlled academic demonstration / staging.

Production is not justified because the current product remains a local Windows Forms + SQL Server LocalDB arrangement, fine-grained access control and durable audit history are incomplete, recovery evidence is absent, and the M3 evidence set is not fully reproducible from the final repository.

## 9. Final Reflection

### Problem and value

CivicConnect addresses fragmented service-request handling by creating one controlled record and visible lifecycle for municipal/community service requests.

### Engineering decisions

- Layered architecture separated presentation, business rules and persistence without introducing unnecessary deployment complexity.
- Domain events reduced coupling between lifecycle changes and audit side effects.
- Adapter boundaries isolate future contractor/vendor contracts from the core request flow.

### Consequences

These decisions improved separation and maintainability, but the project still requires durable history, stronger access control and production operational controls before real deployment.

### Final lesson

The main M4 lesson is that a demonstrated feature and a reproducible controlled repository artefact are not the same thing. Final engineering evidence must be traceable from requirement through implementation and verification.

## 10. Final Evidence Index

| Artefact | Location |
|---|---|
| M1 baseline | `docs/PED-CC-v1.0.md` + submitted M1 PED |
| M2 architecture | `docs/m2/architecture/CivicConnect-Architecture.md` |
| M2 traceability | `docs/m2/M2-Traceability.md` |
| M2 persistence | `docs/m2/data/CivicConnect-Data-Persistence.md` |
| Domain events | `Presentation/BusinessLogic/Infrastructure/DomainEvents/` |
| Contractor adapter | `Presentation/BusinessLogic/Integrations/` |
| M3 recording | Submitted `SEN381 Milestone 3 Recording.mp4` |
| Final RTM | `docs/RTM-v4.0.md` |
| Scope closure | `docs/M4-Scope-Closure.md` |
| M3 closure | `docs/M4-M3-Closure.md` |
| Risk/debt closure | `docs/M4-Risk-and-Debt-Closure.md` |
| Deployment decision | `docs/M4-Deployment-Decision.md` |
| AI usage | `docs/M4-AI-Usage-Register.md` |

## 11. Final Conclusion

CivicConnect has a coherent academic final baseline with meaningful architecture and implementation evidence. It should be presented as a controlled staging/demo product, not a production system. The full M1 scope is below the M4 80% target, and the remaining gaps are explicitly recorded for future controlled work.
