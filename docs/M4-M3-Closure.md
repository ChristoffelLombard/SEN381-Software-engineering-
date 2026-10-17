# M4 M3 Findings and Closure

## M3 evidence reviewed

The submitted `SEN381 Milestone 3 Recording.mp4` presents the release candidate `v3.0.0-RC1` and demonstrates:

1. citizen/staff dashboard flow;
2. four-layer architecture;
3. sequential lifecycle transitions;
4. domain-event audit handling;
5. contractor dispatch adapter boundary;
6. parameterized SQL, optimistic-concurrency and transaction-boundary safeguards;
7. five release requirements traced to implementation and verification;
8. a 184 ms mean response time against a <500 ms target using 20 concurrent sessions;
9. conditional release readiness with zero blockers, while third-party endpoints remained mocked and cloud stress testing remained deferred;
10. a defence summary referring to 15 automated tests and a green GitHub Actions quality gate.

## Closure reconciliation

The current accessible repository confirms the architecture, lifecycle service, domain-event classes and contractor adapter boundary. It does **not** contain a test project corresponding to the claimed 15 automated tests, nor a committed benchmark artefact corresponding to the 184 ms result.

Therefore:

- M3 demonstration evidence remains part of the submitted project evidence.
- Missing artefacts are not recreated or falsely claimed as existing final evidence.
- The performance result is retained as **M3 reported evidence**, not as a reproducible final CI benchmark.
- The mocked contractor endpoint remains a known limitation, consistent with M1 scope.
- Cloud stress testing remains deferred and is not converted into a new M4 testing programme.

## Residual defects / limitations

| ID | Finding | M4 status |
|---|---|---|
| DEF-M4-001 | M3 automated-test evidence is not present in the accessible repository | Open / evidence gap |
| DEF-M4-002 | M3 performance benchmark artefact is not present in the accessible repository | Open / evidence gap |
| DEF-M4-003 | Current repository lifecycle persistence does not include durable status history | Open / implementation limitation |
| DEF-M4-004 | Requester ownership and role-specific access are incomplete | Open / implementation limitation |
| DEF-M4-005 | Production deployment/recovery evidence is incomplete | Open / readiness limitation |

## M3 release decision carried into M4

The M3 recording's `CONDITIONALLY READY` position is retained only for the academic demonstration/staging context. The final production decision is **NO-GO** until the open limitations are addressed.
