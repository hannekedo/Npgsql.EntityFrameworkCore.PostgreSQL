﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Query;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Internal;

namespace Npgsql.EntityFrameworkCore.PostgreSQL.Query.ExpressionTranslators.Internal
{
    /// <summary>
    /// A composite member translator that dispatches to multiple specialized member translators specific to Npgsql.
    /// </summary>
    public class NpgsqlMemberTranslatorProvider : RelationalMemberTranslatorProvider
    {
        public NpgsqlMemberTranslatorProvider(
            [NotNull] RelationalMemberTranslatorProviderDependencies dependencies)
            : base(dependencies)
        {
            var npgsqlSqlExpressionFactory = (NpgsqlSqlExpressionFactory)dependencies.SqlExpressionFactory;

            AddTranslators(
                new IMemberTranslator[] {
                    new NpgsqlStringMemberTranslator(npgsqlSqlExpressionFactory),
                    new NpgsqlDateTimeMemberTranslator(npgsqlSqlExpressionFactory),
                    new NpgsqlRangeTranslator(npgsqlSqlExpressionFactory)
                });
        }
    }
}
