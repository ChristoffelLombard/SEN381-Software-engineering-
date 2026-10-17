# CivicConnect Requirements Traceability Matrix — Final v4.0

| Requirement | Acceptance focus | Final implementation/evidence | Status | Final outcome |
|---|---|---|---|---|
| FR-001 | Valid title, description and category submission | `ServiceRequestService.CreateNewRequest`; current UI does not capture description | PARTIAL | Request creation works but description acceptance is incomplete |
| FR-002 | Controlled configured category | `MainDashboardForm` category ComboBox | MET | Controlled categories implemented |
| FR-003 | Requester + timestamp recorded | `DateCreated` and `LastModifiedBy`; no requester FK | PARTIAL | Timestamp/modifier exist, requester ownership incomplete |
| FR-004 | Requester sees own status only | Shared request dashboard | NOT MET | Requester isolation remains open |
| FR-005 | Requester history | No requester-specific history query | NOT MET | Future work |
| FR-006 | Lifecycle feedback | Status message boxes + notification service | PARTIAL | Feedback exists but complete requester history is absent |
| FR-007 | Staff sees permitted requests | Authentication exists; queue is not responsibility-filtered | PARTIAL | Fine-grained responsibility incomplete |
| FR-008 | Search/filter/sort | `SearchRequests`, category/status filters | PARTIAL | Search/category/status work; time sorting absent |
| FR-009 | Detail + lifecycle history | Dashboard detail view + application audit log | PARTIAL | Detail works; durable history absent |
| FR-010 | Assignment | No assignment model/workflow | NOT MET | Future work |
| FR-011 | Controlled lifecycle + attribution | `AdvanceRequestStatus` + domain-event infrastructure | PARTIAL | Lifecycle exists; durable history not established |
| FR-012 | Action/comment/note | No persisted note model | NOT MET | Future work |
| FR-013 | Authorised resolve/close | Authentication + lifecycle, but no fine-grained role restriction | PARTIAL | Authorisation depth incomplete |
| FR-014 | History retained after closure | No durable history table | NOT MET | Future work |
| FR-015 | Oversight activity | `GetDashboardMetrics` and dashboard metrics | MET | Activity counts implemented |
| FR-016 | Open/overdue/resolved/closed | Status filters; no explicit overdue rule | PARTIAL | State visibility works; overdue incomplete |
| FR-017 | Category/status oversight | Dashboard filters | MET | Implemented |
| FR-018 | Accountability/performance view | Request ID/category/status/date/modifier | PARTIAL | Basic view implemented |
| FR-019 | Rejection reason | No rejection workflow | NOT MET | Should-level item incomplete |
| FR-020 | Requester cannot modify another user's data | No requester ownership enforcement | NOT MET | Security gap remains |
| NFR-001 | Access control | Authentication exists; ownership/role enforcement incomplete | PARTIAL | Production access control not proven |
| NFR-002 | Privacy | No production privacy/retention record | PARTIAL | Production decision open |
| NFR-003 | Availability | No production availability objective | PARTIAL | Staging only |
| NFR-004 | Performance | M3 recording reports 184 ms mean vs <500 ms target; no committed benchmark | PARTIAL | M3 evidence retained, not reproducible from repo |
| NFR-005 | Usability validation | Title/category/location validation exists | PARTIAL | Description path incomplete |
| NFR-006 | Accessibility | Current product is Windows Forms | N/A | No web UI in final baseline |
| NFR-007 | Duplicate handling | No duplicate mechanism demonstrated | NOT MET | Future work |
| NFR-008 | Secure configuration | LocalDB config and demo SQL credentials | PARTIAL | Production configuration still required |
| NFR-009 | Auditability | Domain-event audit logging exists | PARTIAL | Durable lifecycle history absent |
| NFR-010 | Maintainability | Layered architecture + controlled GitHub PR/documentation evidence | MET | Controlled change process evidenced |
| NFR-011 | Recoverability | No tested backup/recovery procedure | NOT MET | Production blocked |
| NFR-012 | Observability | Centralised `ErrorHandler` logging | PARTIAL | Production observability plan incomplete |

## End-to-End Trace

**STK-002/STK-003 → FR-011 → AC-FR-011 → lifecycle/state decision → `ServiceRequestService.AdvanceRequestStatus` → M3 lifecycle demonstration → final status PARTIAL.**

The current implementation contains lifecycle validation and domain-event infrastructure. Final status remains PARTIAL because the final repository does not provide durable status-history storage or the claimed automated verification artefact.

## Evidence rule

M3 video evidence is retained as submitted demonstration evidence. The final repository is treated as the authoritative source for implementation artefacts. Missing repository artefacts are not claimed as final evidence.
