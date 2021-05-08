using AspNetCore.Identity.MongoDbCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark.Models.ViewModels.Personels
{
    public class PersonelMainRole
    {
        public List<MongoIdentityRole> Roles { get; set; }
        public List<PersonelRoles> PersonelRoleList { get; set; }
    }
    public class PersonelRoles
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
