# M4 Closure Registers

## 1. M3 Findings / Defects

| ID | Finding | Status |
|---|---|---|
| DEF-M4-001 | M3 recording claims 15 automated tests, but corresponding test artefact is not in the accessible final repository | Open evidence gap |
| DEF-M4-002 | M3 recording reports 184 ms performance evidence, but benchmark artefact is not committed | Open evidence gap |
| DEF-M4-003 | Durable lifecycle history is not present in the current database schema | Open limitation |
| DEF-M4-004 | Requester ownership and fine-grained authorisation are incomplete | Open limitation |
| DEF-M4-005 | Production recovery/configuration/operational evidence is incomplete | Open limitation |

## 2. Risk Closure

| Risk | Final status | Conclusion |
|---|---|---|
| RISK-001 Governance evidence gap | Reduced | GitHub repository and PR history now provide controlled evidence; final team approval remains required. |
| RISK-002 Scope growth | Closed for M4 | No new optional product scope is introduced. |
| RISK-003 Unjustified technology choice | Closed | M2 selected and documented the current stack. |
| RISK-004 Unauthorised access | Open | Authentication exists, but ownership/role depth is incomplete. |
| RISK-005 Missing traceability after change | Reduced | Final RTM and PED are version-controlled. |
| RISK-006 Schedule pressure | Open | Full M1 scope remains below the M4 80% target. |
| RISK-007 Privacy/legal assumptions | Open | No production compliance claim is made. |
| RISK-008 AI-generated errors | Controlled | AI usage is recorded; human verification remains required. |
| RISK-009 Repository secrets | Open | SQL seed data contains known demo credentials and is not suitable for production. |

## 3. Technical Debt

Retained debt: requester ownership, role-based access depth, assignment persistence, durable lifecycle history, notes/rejection workflow, automated regression evidence, reproducible performance benchmark, production recovery and production observability/configuration.

M4 records these items rather than creating a new architecture or testing programme.

## 4. Deployment Decision

**NO-GO FOR PRODUCTION.**

**Final permitted state:** controlled academic demonstration / staging.

Reasons: local Windows Forms + LocalDB deployment, incomplete production access control, incomplete durable audit history, missing recovery evidence, unresolved scope gap and non-reproducible portions of M3 verification evidence.

## 5. AI Usage Register

| Activity | AI assistance | Human verification |
|---|---|---|
| M4 repository review | Code/document inspection and gap analysis | Compare every claim with actual GitHub files and submitted M3 evidence |
| PED/RTM drafting | Structured drafting and status mapping | Verify requirement wording, implementation path and final evidence |
| Code review | Identify lifecycle/configuration inconsistencies | Team must review and accept final PR; CI/build verification remains required |

AI assistance does not constitute repository approval, test execution, stakeholder evidence, lecturer approval or final sign-off.
