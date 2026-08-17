# Expense Tracker (C#)

A Windows Forms desktop application for tracking the income and expenses of a school prefects'
body. Built in 2022 as my final project for NIBM.

This repository is an **archived snapshot of the project as it was submitted**. The code has not
been modernised, refactored, or cleaned up before publishing — what's here is what I wrote at the
time. See [Honest caveats](#honest-caveats) below, which is the part of this README worth reading
if you're evaluating the code.

## Context

The application was written for the Prefects' Body of St. Joseph's College to replace a manual
paper ledger. It tracks two sides of a budget:

- **Advertisements** — income raised by members selling advertisement space, recorded against the
  member who collected it and their rank.
- **Expenses** — money withdrawn by committees, recorded with a receipt number and an approver.

The "cash at hand" figure is then simply the sum of all advertisement income minus the sum of all
expenses.

## Tech stack

| | |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| UI | Windows Forms |
| Database | Microsoft SQL Server (accessed via `System.Data.SqlClient`) |
| IDE | Visual Studio 2022 |
| Distribution | ClickOnce |

No third-party libraries, no NuGet packages — the standard library only.

## Features

**Advertisement / income tracking**
- Record an advertisement sale against a member, rank, entity, and collector
- Advertisement type auto-fills a fixed price from a preset tier list
- Delete an advertisement entry by matching its details

**Expense tracking**
- Record an expense against a committee, member, receipt number, and approver
- Delete an expense entry by matching its details
- Required-field validation on both entry forms

**Board / admin view**
- Total cash at hand (total income minus total expenses)
- Total expenses, filterable by committee or by member and rank
- Total advertisement income, filterable by member and rank
- Grid views of the raw `expenses` and `advertisements` tables
- Delete rows directly by primary key

Ten forms in total, with navigation from a central `Home` screen.

## Honest caveats

I'm publishing this as-is rather than quietly fixing things first, so the limitations should be
stated plainly. Most of these are the reason it's an archived student project and not something to
actually deploy.

**It will not run out of the box.** This is the big one.

- **The database isn't included.** There is no schema file, no migration, and no seed data in this
  repository. The application expects a SQL Server database named `Nibmfinaltest` containing
  `expenses` and `advertisements` tables. You'd have to reconstruct those tables yourself by
  reading the queries in the source before the app would do anything.
- **The connection string is hardcoded** in seven separate files, pointing at
  `Data Source=DESKTOP-9BT8OBG` — a machine that no longer matters to anyone. It uses Windows
  integrated authentication, so no password is exposed, but every one of those seven files would
  need editing to point somewhere else. It belongs in `App.config`, once.
- **The ClickOnce signing key is not committed.** The `.csproj` has `SignManifests` enabled and
  references a `.pfx` that is deliberately excluded from this repository, because private keys
  shouldn't be published. A fresh clone will fail to build until you either supply your own key or
  untick *Project Properties → Signing → Sign the ClickOnce manifests*.

**Security and code quality.**

- **Every SQL query is built by string concatenation** from text box input — 35 of them. This is
  textbook SQL injection. It was never exploitable in practice, because the app ran locally against
  a local database with a single trusted operator and no network exposure, but it is the first
  thing anyone reading this code will notice, and it's wrong. Parameterised queries
  (`SqlParameter`) are the fix.
- **There is no authentication.** The "For Admin Access Only" button on the home screen opens the
  board view directly, with no password check of any kind.
- **Amounts are stored and compared as strings** rather than a numeric or decimal type.
- **Error handling is a blanket `try/catch (Exception)`** around each handler, usually surfacing
  "Something Went Wrong" and swallowing the real error. Debugging it is unpleasant.
- **There are no tests.**

**Other things worth knowing.**

- 100% local, single-machine, single-user. No networking, no concurrency handling, no multi-user
  support, no audit trail.
- Data is deleted by matching on field values rather than by ID in several forms, so identical rows
  can be removed together unintentionally.
- The `.resx` files are large (~36 MB total) because the form background images are embedded in
  them as base64. That's a Windows Forms designer default, not a deliberate choice.
- GitHub reports this repository as 100% C#. That's accurate by file extension, but slightly
  misleading — a meaningful part of the work was SQL, and all of it lives inside C# string
  literals rather than in `.sql` files.

## Building

Requires Visual Studio with the .NET desktop development workload, and SQL Server for the app to
have anything to talk to.

1. Clone the repository and open `NibmFinalProjectExpenseTracker.sln`.
2. Turn off manifest signing (*Project Properties → Signing*), since the `.pfx` isn't included.
3. Create a SQL Server database and reconstruct the `expenses` and `advertisements` tables by
   reading the `INSERT` statements in `ExpenseAdd.cs` and `BudgetUpdater.cs` for column order.
4. Update the connection string in all seven files that contain one.
5. Build and run.

## A note on how this was written

**The application code was written entirely by hand in 2022**, before I had any access to AI coding
assistants. Every line of it — the good decisions and the bad ones alike — is mine. The flaws listed
above are genuine beginner mistakes from the time, and I've left them in place rather than
retrofitting fixes, because an accurate record of where I started is more useful than a polished one.

**This README, however, was generated with Claude Code** when I published the project in 2026, based
on an analysis of the existing source. I'm noting it for the sake of complete transparency: the
project is pre-AI, the documentation is not. No application code was changed, added, or rewritten in
the process.

## Status

Archived. Kept as a record of early work; not maintained and not accepting changes.
