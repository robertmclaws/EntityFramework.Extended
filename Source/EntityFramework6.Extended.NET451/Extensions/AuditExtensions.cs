using System;
using System.Data.Entity;
#if EF5
using System.Data.Objects;
#elif EF6 || EF61
using System.Data.Entity.Core.Objects;
#endif
using EntityFramework.Audit;

namespace EntityFramework.Extensions
{
    /// <summary>
    /// An extension class for AuditLog.
    /// </summary>
    public static class AuditExtensions
    {
        /// <summary>
        /// Begin audit logging by attaching an AuditLogger to the ObjectContext.
        /// </summary>
        /// <param name="objectContext">The ObjectContext to create the AuditLog from.</param>
        /// <param name="configuration">The AuditConfiguration to use when creating the AuditLog.</param>
        /// <returns>An Auditlogger instance to create an AuditLog from.</returns>
        public static AuditLogger BeginAudit(this ObjectContext objectContext, AuditConfiguration configuration = null)
        {
            return new AuditLogger(objectContext, configuration);
        }

        /// <summary>
        /// Begin audit logging by attaching an AuditLogger to the ObjectContext.
        /// </summary>
        /// <param name="dbContext">The DbContext to create the AuditLog from.</param>
        /// <param name="configuration">The AuditConfiguration to use when creating the AuditLog.</param>
        /// <returns>An Auditlogger instance to create an AuditLog from.</returns>
        public static AuditLogger BeginAudit(this DbContext dbContext, AuditConfiguration configuration = null)
        {
            return new AuditLogger(dbContext, configuration);
        }
    }
}