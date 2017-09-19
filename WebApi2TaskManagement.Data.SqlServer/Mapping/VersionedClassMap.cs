using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi2TaskManagement.Data.Entities;

namespace WebApi2TaskManagement.Data.SqlServer.Mapping
{
    public abstract class VersionedClassMap<T> : ClassMap<T> where T : IVersionedEntity
    {
        protected VersionedClassMap()
        {
            Version(x => x.Version).
                Column("ts").
                CustomSqlType("Rowversion").
                Generated.Always().
                UnsavedValue("null");
        }
    }
}
