# M4 Final Deployment / Go-Live Decision

## Decision

**NO-GO for production.**

**Permitted final state:** controlled academic demonstration / staging.

## Evidence

- Windows Forms application targets Windows and runs against SQL Server LocalDB.
- Production hosting is not established in the M2 architecture baseline.
- M3 reported conditional readiness, but explicitly retained mocked third-party endpoints and deferred cloud stress testing.
- The current repository does not contain the automated test artefact or performance benchmark artefact claimed in the M3 recording.
- Requester ownership, assignment, durable lifecycle history and fine-grained authorisation remain incomplete.
- Backup/recovery responsibility and tested recovery evidence are not established.

## Go-live blockers

1. Complete role and ownership enforcement.
2. Add durable lifecycle history and attributable action records.
3. Establish production-grade configuration and secret handling.
4. Define and test backup/recovery responsibility.
5. Reproduce critical M3 verification evidence in controlled repository artefacts.
6. Resolve the remaining scope gap against the M1 baseline.

## Future go-live gate

Production may only be reconsidered when the above conditions are evidenced in the RTM, PED, repository and final verification records.
