# M4 Risk, Technical Debt and Limitation Closure

| Item | Final status | Consequence / action |
|---|---|---|
| RISK-001 governance/review evidence | Reduced | Repository and PR history now provide controlled change evidence; final team approval remains required. |
| RISK-002 scope growth | Closed for M4 | No new optional product scope is introduced. |
| RISK-003 technology choice | Closed | .NET 8, WinForms, ADO.NET and LocalDB remain the selected academic stack. |
| RISK-004 unauthorised access | Open | Authentication exists, but fine-grained ownership/role enforcement remains incomplete. |
| RISK-005 traceability after change | Reduced | Final RTM and M4 closure artefacts are version-controlled. |
| RISK-006 schedule pressure | Open | M1 scope is below the M4 80% target; optional work is not being disguised as complete. |
| RISK-007 privacy/legal assumptions | Open | No production privacy/legal compliance claim is made. |
| RISK-008 AI-generated errors | Controlled | Material AI assistance is recorded in the M4 AI Usage Register; human review is required before merge/submission. |
| RISK-009 repository secrets | Open | Demo seed credentials are present in SQL setup and must not be treated as production credentials. |

## Technical debt retained

- Durable lifecycle-history persistence.
- Requester ownership and role-based access depth.
- Assignment persistence.
- Automated regression test artefacts.
- Reproducible performance benchmark artefact.
- Production backup/recovery and observability controls.
- Production configuration and dependency upgrade planning.

## Debt decision

The debt is explicitly retained rather than silently repaid during M4 because M4 is a finalisation milestone, not a new architecture or test-programme milestone. These items are recorded as conditions for any future production increment.
