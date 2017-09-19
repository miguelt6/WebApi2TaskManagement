using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi2TaskManagement.Data.Entities;

namespace WebApi2TaskManagement.Data.SqlServer.Mapping
{
    public class UserMap : VersionedClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.UserId);
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
            Map(x => x.UserName).Not.Nullable();
        }
    }
}
