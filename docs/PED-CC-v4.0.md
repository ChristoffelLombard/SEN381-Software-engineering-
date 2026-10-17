# CivicConnect Project Engineering Document — PED v4.0

## Final Engineering Baseline — Milestone 4

**Project:** CivicConnect — Community Service Request Management Platform  
**Module:** SEN381 Software Engineering 381  
**Version:** v4.0  
**Status:** Finalisation draft — pending team review and approval  
**Final branch:** `feat/m4-finalisation`  
**Final commit:** populated after the final M4 commit  
**Authors:** Christoffel Lombard (602390); Petrus Barend Wentzel (601201)

---

## 1. Purpose

M4 closes the same CivicConnect project established in M1. It does not create a new product baseline. This document records what was committed, what was delivered, what remains incomplete, the evidence available from M3 and the final repository state, and the resulting deployment decision.

M4 uses the submitted M3 recording as M3 demonstration evidence and the controlled GitHub repository as the final engineering baseline.

## 2. Final Product Summary

The final repository contains a C#/.NET 8 Windows Forms application using a layered Presentation, Business Logic, Data Access and Models structure. SQL Server LocalDB is used for persistence. The implemented product includes authentication, a service-request dashboard, request creation, search/filtering, lifecycle status changes, notifications, escalation strategies, domain-event audit handling and an adapter boundary for contractor dispatch.

The M3 recording demonstrated the intended release candidate as `v3.0.0-RC1`, including the full request loop, lifecycle state machine, domain-event audit boundary, adapter boundary, database safeguards, RTM and performance evidence.

A reconciliation is required because several M3 claims are not represented by equivalent artefacts in the current accessible GitHub baseline. Those gaps are recorded rather than treated as completed evidence.

## 3. M1 Scope Closure

| M1 area | Final status | Conclusion |
|---|---|---|
| Request creation | PARTIALLY IMPLEMENTED | Title/category/location/priority are captured; the current UI does not collect a non-empty description field. |
| Controlled categories | IMPLEMENTED | Category selection uses a fixed configured list. |
| Requester identity/history | PARTIALLY IMPLEMENTED | The authenticated username is retained as the modifier, but requester ownership and requester-only history are not fully represented in the current schema. |
| Staff queue/filtering | PARTIALLY IMPLEMENTED | Search, category and status filtering exist; role-specific responsibility and time sorting are not fully implemented. |
| Request detail/lifecycle history | PARTIALLY IMPLEMENTED | Request details and status are available, but durable status-history records are not present in the current database schema. |
| Assignment | NOT IMPLEMENTED | No assignment table/workflow is present in the final repository baseline. |
| Controlled lifecycle | PARTIALLY IMPLEMENTED | Business logic enforces sequential status rules, but the repository baseline required reconciliation with the M3 claim of complete transition-history persistence. |
| Action/comment/resolution notes | NOT IMPLEMENTED | No persisted notes model is present. |
| Authorised resolve/close | PARTIALLY IMPLEMENTED | Lifecycle operations exist, but the current UI/service does not enforce role-specific authorisation for each lifecycle action. |
| Lifecycle history after closure | NOT IMPLEMENTED | No durable history table is present. |
| Oversight activity view | IMPLEMENTED | Dashboard metrics provide total, pending, in-progress and resolved/closed counts. |
| Open/overdue/resolved/closed view | PARTIALLY IMPLEMENTED | Statuses are visible; an explicit overdue rule is not implemented in the current repository. |
| Category/status oversight | IMPLEMENTED | Category and status filters are available. |
| Accountability/performance view | PARTIALLY IMPLEMENTED | Request identifiers, status, category and dates are available, but assignment/history depth is limited. |
| Rejection reason | NOT IMPLEMENTED | No rejection workflow/reason field is present. |
| Requester isolation | NOT IMPLEMENTED | The current dashboard loads the shared request queue rather than a requester-owned subset. |

## 4. M1 Non-Functional Requirement Closure

| Requirement | Final status | Evidence/conclusion |
|---|---|---|
| NFR-001 Access control | PARTIALLY IMPLEMENTED | Login/authentication exists, but fine-grained server/service-side role and ownership enforcement is incomplete. |
| NFR-002 Privacy | PARTIALLY IMPLEMENTED | The system is local/demo-oriented; a production privacy/data-retention decision is not evidenced. |
| NFR-003 Availability | PARTIALLY IMPLEMENTED | M3 considered readiness but production availability was not established. |
| NFR-004 Performance | PARTIALLY VERIFIED | M3 recording reports 184 ms mean response time against a <500 ms target using 20 concurrent sessions. The current repository does not contain the claimed automated benchmark artefact. |
| NFR-005 Usability | PARTIALLY IMPLEMENTED | Labels, controlled lists and validation feedback exist; description capture is incomplete. |
| NFR-006 Accessibility | NOT APPLICABLE TO CURRENT WEB SCOPE | CivicConnect is a Windows Forms desktop application; the M1 WCAG condition was framed for web content introduced later. |
| NFR-007 Reliability | PARTIALLY IMPLEMENTED | Repository operations use parameterized commands; duplicate-submission handling is not demonstrated. |
| NFR-008 Secure configuration | PARTIALLY IMPLEMENTED | The repository contains no application connection secret, but the SQL seed script contains demo credentials and the original connection string is local-machine configuration. |
| NFR-009 Auditability | PARTIALLY IMPLEMENTED | Domain events emit status-change audit information to the application log, but durable lifecycle-history storage is not represented in the current schema. |
| NFR-010 Maintainability | IMPLEMENTED FOR CONTROLLED REPOSITORY WORK | M2 work was merged through GitHub PRs and the repository contains layered components and controlled documentation. |
| NFR-011 Recoverability | NOT VERIFIED | LocalDB is a development arrangement and no tested backup/recovery procedure is part of the repository baseline. |
| NFR-012 Observability | PARTIALLY IMPLEMENTED | Centralised application logging exists, but a production observability/health plan is not evidenced. |

## 5. M3 Findings and Closure

The submitted M3 recording reported:

- release candidate `v3.0.0-RC1`;
- a full service-request loop;
- layered architecture;
- sequential lifecycle transitions;
- domain-event audit handling;
- an adapter boundary for contractor dispatch;
- parameterized SQL, optimistic-concurrency and transaction-boundary safeguards;
- RTM evidence showing five release requirements as passed;
- a 184 ms mean response time against a <500 ms target;
- zero release blockers, with mocked third-party endpoints and deferred cloud stress testing recorded as residual risks;
- a final defence statement describing 15 automated tests and a green GitHub Actions quality gate.

The current accessible GitHub repository does contain the layered architecture, lifecycle service, domain-event components and adapter boundary. However, the repository does not contain a corresponding automated test project or the claimed performance test artefact. The M3 recording therefore remains valid as submitted demonstration evidence, but the final repository must not claim those missing artefacts as independently reproducible final evidence.

## 6. Final Quality Position

The final product is suitable as a controlled academic demonstration/staging baseline, not as a production deployment. The remaining limitations are material because requester ownership, assignment, durable lifecycle history, fine-grained authorisation and production operational controls are incomplete.

## 7. Deployment Decision

**Decision: NO-GO for production.**

**Reason:** The current repository is a local Windows Forms + SQL Server LocalDB development/staging arrangement. Production deployment evidence for access control, recovery, privacy, durable audit history, external integrations and operational monitoring is incomplete. M3 also carried explicit residual risks for mocked third-party endpoints and deferred cloud stress testing.

The valid final state is therefore **simulated production / controlled staging for academic demonstration**, with the production decision deferred until the documented limitations are addressed.

## 8. Technical Debt and Known Limitations

1. Requester ownership is not represented as a relational foreign key in the current schema.
2. Assignment is not persisted.
3. Lifecycle history is logged through domain events/application logging rather than a durable history table.
4. The current repository does not reproduce the M3 automated test evidence.
5. M3 performance evidence is not reproduced by a committed benchmark artefact.
6. LocalDB remains a single-machine development dependency.
7. Demo credentials exist in the SQL seed script and must be treated as non-production credentials.
8. .NET 8 is nearing the end of its support period and should be upgraded before any real production deployment.

## 9. Final Reflection

### Problem and value

CivicConnect addresses the fragmentation of service requests by providing one controlled request record and a visible lifecycle.

### Quality

The project established useful engineering structure through layered architecture, repositories, controlled lifecycle rules, domain events and an adapter boundary. M3 provided evidence of the intended quality baseline, while M4 reconciles that evidence against the repository rather than assuming that every demonstrated claim is reproducible.

### Decisions and consequences

- Layered architecture improved separation of UI, business rules and persistence but increased the number of components that must remain consistent.
- Domain events reduced direct coupling between status changes and audit side effects, but the in-memory event mechanism is not durable across restarts.
- Adapter-based contractor integration keeps vendor-specific contracts outside the core request flow, but live integration remains intentionally outside the committed baseline.

### Team execution

The project progressed through M1 requirements, M2 architecture/design and M3 construction/verification. M4 consolidates the evidence and records remaining gaps instead of silently treating them as complete.

### Future work

The next engineering increment should prioritise role/ownership enforcement, durable request history, assignment, notes/rejection handling, automated regression tests, production-grade configuration and operational recovery before any production go-live.

## 10. Final Evidence Index

| Evidence | Location |
|---|---|
| M1 baseline | `docs/PED-CC-v1.0.md` and submitted M1 PED |
| M2 architecture | `docs/m2/architecture/CivicConnect-Architecture.md` |
| M2 traceability | `docs/m2/M2-Traceability.md` |
| M2 persistence decision | `docs/m2/data/CivicConnect-Data-Persistence.md` |
| Domain events | `Presentation/BusinessLogic/Infrastructure/DomainEvents/` |
| Contractor adapter | `Presentation/BusinessLogic/Integrations/` |
| M3 demonstration | Submitted `SEN381 Milestone 3 Recording.mp4` |
| Final RTM | `docs/RTM-v4.0.md` |
| Scope closure | `docs/M4-Scope-Closure.md` |
| M3 closure | `docs/M4-M3-Closure.md` |
| Risk/debt closure | `docs/M4-Risk-and-Debt-Closure.md` |
| Deployment decision | `docs/M4-Deployment-Decision.md` |
| AI usage | `docs/M4-AI-Usage-Register.md` |

---

**M4 conclusion:** CivicConnect has a coherent academic final baseline and strong architectural evidence, but the current repository does not justify a production go-live claim. The remaining gaps are explicitly recorded for controlled future work.
