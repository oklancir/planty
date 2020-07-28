// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Naming",
    "CA1716:Identifiers should not match keywords",
    Justification = "DbContext Set.",
    Scope = "member",
    Target = "~M:Planty.Data.Interfaces.IReadOnlyDatabaseContext.Set``1~Microsoft.EntityFrameworkCore.DbSet{``0}")]
[assembly: SuppressMessage("Info Code Smell", "S1309:Track uses of in-source issue suppressions", Justification = "Some rules need suppression.")]
