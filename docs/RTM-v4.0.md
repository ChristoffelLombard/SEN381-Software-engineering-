# CivicConnect Requirements Traceability Matrix — Final v4.0

This RTM closes the M1 traceability chain through the final repository baseline. Statuses are intentionally evidence-based.

| Requirement | Acceptance focus | Engineering decision/design | Final implementation/evidence | Final status | Outcome |
|---|---|---|---|---|---|
| FR-001 | Valid title, description and category submission | Layered validation | `ServiceRequestService.CreateNewRequest`; current UI does not capture description | PARTIAL | Request creation works, but description acceptance is incomplete |
| FR-002 | Controlled configured category | UI controlled list | `MainDashboardForm` category ComboBox | MET | Controlled category selection demonstrated |
| FR-003 | Requester + timestamp recorded | Repository persistence | `DateCreated`, `LastModifiedBy`; no requester FK | PARTIAL | Timestamp/modifier exist, requester ownership is incomplete |
| FR-004 | Requester sees own request status only | Role/ownership control | Shared dashboard currently loads general queue | NOT MET | Requester isolation remains open |
| FR-005 | Requester history list | Requester-owned query | No requester-specific history query | NOT MET | Future work required |
| FR-006 | Lifecycle feedback | UI notification strategy | Notification service + status message boxes | PARTIAL | Feedback exists, but full requester event history is not present |
| FR-007 | Staff sees permitted requests | Role/responsibility rule | Authentication exists; request queue is not responsibility-filtered | PARTIAL | Authentication exists, fine-grained responsibility is incomplete |
| FR-008 | Search/filter/sort by useful criteria | Repository search/filter | `SearchRequests`, category/status filters | PARTIAL | Search/category/status work; time sorting is absent |
| FR-009 | Full permitted detail/history | Layered detail view + audit | Dashboard details + domain-event audit log | PARTIAL | Details work; durable history is missing |
| FR-010 | Assignment records assignee/actor/time | Assignment persistence | No assignment schema/workflow | NOT MET | Future work required |
| FR-011 | Invalid transition rejected; accepted transition attributable | State pattern + domain event | `AdvanceRequestStatus`; event contains actor/time | PARTIAL | State enforcement exists; durable history is incomplete |
| FR-012 | Attributable action/comment/note | Domain event / persistence boundary | No persisted note model | NOT MET | Future work required |
| FR-013 | Only authorised staff resolve/close | Access control | Authentication exists but status action is not role-restricted | PARTIAL | Lifecycle exists; authorisation needs strengthening |
| FR-014 | Lifecycle history retained after closure | Durable history model | Current schema has no history table | NOT MET | Future work required |
| FR-015 | Oversight activity view | Dashboard aggregation | `GetDashboardMetrics` + dashboard header | MET | Activity counts are available |
| FR-016 | Open/overdue/resolved/closed distinction | Status/overdue rule | Status filters exist; no explicit overdue rule | PARTIAL | State visibility works; overdue remains open |
| FR-017 | Category and status view | Controlled filters | Dashboard category/status filters | MET | Both filters are implemented |
| FR-018 | Accountability/performance view | Dashboard/detail model | Request ID, category, status, created date and modifier visible | PARTIAL | Basic accountability view exists |
| FR-019 | Rejection reason | Controlled rejection state | No rejection workflow | NOT MET | Should-level item remains incomplete |
| FR-020 | Requester cannot modify another user's data | Ownership enforcement | No requester ownership enforcement | NOT MET | Security gap remains |
| NFR-001 | Role/ownership negative tests | Access-control boundary | Login/authentication only; no fine-grained ownership enforcement | PARTIAL | Authentication works; authorisation depth incomplete |
| NFR-002 | Privacy/data inventory and retention decision | M1 privacy baseline | Local demo application; no production privacy record | PARTIAL | Production privacy decision remains open |
| NFR-003 | Availability target and measurement | Deployment decision deferred | No production availability target in repo | PARTIAL | Staging only |
| NFR-004 | Representative performance target | Performance evidence | M3 recording reports 184 ms mean vs <500 ms target, 20 sessions | PARTIAL | Demonstrated in M3, not reproduced as a committed benchmark artefact |
| NFR-005 | Field-specific validation | UI/business validation | `CreateNewRequest` validates title/category/location | PARTIAL | Validation exists, description capture is incomplete |
| NFR-006 | WCAG assessment for web content | Web accessibility boundary | Current product is Windows Forms | N/A | No web UI is part of the final baseline |
| NFR-007 | Duplicate handling | M2/M3 reliability mechanism | No duplicate-detection mechanism demonstrated | NOT MET | Future work required |
| NFR-008 | No committed secrets / approved config | Environment-specific configuration | LocalDB connection + demo SQL seed credentials | PARTIAL | Production secret handling still required |
| NFR-009 | Actor/time/request auditability | Domain event + audit handler | `StatusChangeAuditHandler` logs request, old/new status, actor and UTC time | PARTIAL | Audit event exists; durable lifecycle history absent |
| NFR-010 | Traceable controlled changes and review | Git/GitHub workflow | M2 PRs and controlled docs present | MET | Repository change control is evidenced |
| NFR-011 | Backup/recovery readiness | Deployment/go-live decision | No tested backup/recovery procedure | NOT MET | Production blocked |
| NFR-012 | Operational failure detection | Centralised logging | `ErrorHandler` writes application log | PARTIAL | Basic logging exists; production observability plan absent |

## End-to-End Trace Example

**STK-002 / STK-003 → FR-011 → AC-FR-011 → State lifecycle decision → `ServiceRequestService.AdvanceRequestStatus` → M3 lifecycle demonstration → final status PARTIAL.**

The current implementation enforces lifecycle transition rules and publishes a `ServiceRequestStatusChangedEvent`. The final status remains PARTIAL because the current database schema does not provide durable status-history storage and the M3 automated verification artefact is not present in the repository.

## Final Traceability Rule

The M4 repository baseline is the authoritative implementation evidence. The submitted M3 recording remains demonstration evidence, but it is not treated as proof that an artefact exists in GitHub when that artefact cannot be located in the final repository.
