# CivicConnect — Community Service Request Management Platform

[![Course](https://img.shields.io/badge/Course-SEN381%20Software%20Engineering-blue)](https://github.com/BernardW88/SEN381-Software-engineering-)
[![Milestone](https://img.shields.io/badge/Milestone-M4%20Final-orange)](./docs/PED-CC-v4.0.md)
[![Status](https://img.shields.io/badge/Deployment-Stage%2FDemo-yellow)](./docs/PED-CC-v4.0.md)

> **Software Engineering 381 (SEN381)** | CivicConnect final engineering baseline (PED v4.0)  
> **Authors:** Christoffel Lombard (602390) & Petrus Barend Wentzel (601201)

---

## Problem & Scope

CivicConnect addresses fragmented service-request channels by providing one controlled request record with visible lifecycle information.

## Current Final Baseline

The final academic baseline is a C#/.NET 8 Windows Forms application using Business Logic, Data Access and Models layers with SQL Server LocalDB persistence.

The final product is approved for **controlled academic demonstration/staging**, not production deployment. The detailed final decision and remaining limitations are recorded in `docs/PED-CC-v4.0.md`.

## Key Engineering Documents

- **PED v4.0:** `docs/PED-CC-v4.0.md`
- **Final RTM:** `docs/RTM-v4.0.md`
- **M4 closure registers:** `docs/M4-Closure-Registers.md`
- **M1 baseline:** `docs/PED-CC-v1.0.md`
- **M2 traceability:** `docs/m2/M2-Traceability.md`
- **M2 architecture:** `docs/m2/architecture/CivicConnect-Architecture.md`

## Project Governance

Substantive changes are intended to use GitHub branches and pull requests. The final M4 branch is `feat/m4-finalisation-v2`; it is intended for team review before merge.

## Repository Layout

```text
├── .github/              # GitHub workflow and PR controls
├── docs/                 # M1-M4 engineering documentation
├── Presentation/         # WinForms application and supporting projects
├── src/                  # Existing project placeholder
├── .gitignore
└── README.md
```
