// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Design",
    "CA1062:Validate arguments of public methods",
    Justification = "ValidateIsNotNull",
    Scope = "member",
    Target = "~M:Planty.Business.Services.PlantService.UpdateAsync(System.Guid,Planty.Data.Entities.Plant)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage(
    "Major Code Smell",
    "S3900:Arguments of public methods should be validated against null",
    Justification = "ValidateIsNotNull",
    Scope = "member",
    Target = "~M:Planty.Business.Services.PlantService.UpdateAsync(System.Guid,Planty.Data.Entities.Plant)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Info Code Smell", "S1309:Track uses of in-source issue suppressions", Justification = "I will supress issues")]
[assembly: SuppressMessage(
    "Design",
    "CA1062:Validate arguments of public methods",
    Justification = "ValidateIsNotNull",
    Scope = "member",
    Target = "~M:Planty.Business.Services.PlantService.CreateAsync(Planty.Business.Models.PlantBase)~System.Threading.Tasks.Task{Planty.Business.Models.Plant}")]
[assembly: SuppressMessage(
    "Design",
    "CA1062:Validate arguments of public methods",
    Justification = "ValidateIsNotNull",
    Scope = "member",
    Target = "~M:Planty.Business.Services.PlantService.UpdateAsync(System.Guid,Planty.Business.Models.PlantBase)~System.Threading.Tasks.Task{Planty.Business.Models.Plant}")]
[assembly: SuppressMessage(
    "Major Code Smell",
    "S3900:Arguments of public methods should be validated against null",
    Justification = "ValidateIsNotNull",
    Scope = "member",
    Target = "~M:Planty.Business.Services.AuthenticationService.RegisterAsync(Planty.Business.Models.User)~System.Threading.Tasks.Task{Planty.Business.Models.User}")]
[assembly: SuppressMessage(
    "Design",
    "CA1062:Validate arguments of public methods",
    Justification = "ValidateIsNotNull",
    Scope = "member",
    Target = "~M:Planty.Business.Services.Users.UserService.CreateAsync(Planty.Business.Models.UserBase)~System.Threading.Tasks.Task{Planty.Business.Models.User}")]
[assembly: SuppressMessage(
    "Design",
    "CA1062:Validate arguments of public methods",
    Justification = "ValidateIsNotNull",
    Scope = "member",
    Target = "~M:Planty.Business.Services.Users.UserService.UpdateAsync(System.Guid,Planty.Business.Models.UserBase)~System.Threading.Tasks.Task{Planty.Business.Models.User}")]
