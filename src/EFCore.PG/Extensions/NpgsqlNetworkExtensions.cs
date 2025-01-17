﻿using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    /// Provides extension methods supporting operator translation for PostgreSQL network types.
    /// </summary>
    /// <remarks>
    /// See: https://www.postgresql.org/docs/current/static/functions-net.html
    /// </remarks>
    public static class NpgsqlNetworkExtensions
    {
        #region RelationalOperators

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is less than another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The left-hand inet.</param>
        /// <param name="other">The right-hand inet.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is less than the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool LessThan([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) is less than another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The left-hand cidr.</param>
        /// <param name="other">The right-hand cidr.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) is less than the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool LessThan([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="PhysicalAddress"/> is less than another <see cref="PhysicalAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macaddr">The left-hand macaddr.</param>
        /// <param name="other">The right-hand macaddr.</param>
        /// <returns>
        /// True if the <see cref="PhysicalAddress"/> is less than the other <see cref="PhysicalAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool LessThan([CanBeNull] this DbFunctions _, PhysicalAddress macaddr, PhysicalAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is less than or equal to another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The left-hand inet.</param>
        /// <param name="other">The right-hand inet.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is less than or equal to the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool LessThanOrEqual([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) is less than or equal to another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The left-hand cidr.</param>
        /// <param name="other">The right-hand cidr.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) is less than or equal to the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool LessThanOrEqual([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="PhysicalAddress"/> is less than or equal to another <see cref="PhysicalAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macaddr">The left-hand macaddr.</param>
        /// <param name="other">The right-hand macaddr.</param>
        /// <returns>
        /// True if the <see cref="PhysicalAddress"/> is less than or equal to the other <see cref="PhysicalAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool LessThanOrEqual([CanBeNull] this DbFunctions _, PhysicalAddress macaddr, PhysicalAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is greater than or equal to another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The left-hand inet.</param>
        /// <param name="other">The right-hand inet.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is greater than or equal to the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool GreaterThanOrEqual([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) is greater than or equal to another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The left-hand cidr.</param>
        /// <param name="other">The right-hand cidr.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) is greater than or equal to the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool GreaterThanOrEqual([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="PhysicalAddress"/> is greater than or equal to another <see cref="PhysicalAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macaddr">The left-hand macaddr.</param>
        /// <param name="other">The right-hand macaddr.</param>
        /// <returns>
        /// True if the <see cref="PhysicalAddress"/> is greater than or equal to the other <see cref="PhysicalAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool GreaterThanOrEqual([CanBeNull] this DbFunctions _, PhysicalAddress macaddr, PhysicalAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is greater than another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The left-hand inet.</param>
        /// <param name="other">The right-hand inet.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is greater than the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool GreaterThan([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) is greater than another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The left-hand cidr.</param>
        /// <param name="other">The right-hand cidr.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) is greater than the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool GreaterThan([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="PhysicalAddress"/> is greater than another <see cref="PhysicalAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macaddr">The left-hand macaddr.</param>
        /// <param name="other">The right-hand macaddr.</param>
        /// <returns>
        /// True if the <see cref="PhysicalAddress"/> is greater than the other <see cref="PhysicalAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool GreaterThan([CanBeNull] this DbFunctions _, PhysicalAddress macaddr, PhysicalAddress other)
            => throw ClientEvaluationNotSupportedException();

        #endregion

        #region ContainmentOperators

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is contained within another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to locate.</param>
        /// <param name="other">The inet to search.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is contained within the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainedBy([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is contained within a network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to locate.</param>
        /// <param name="other">The cidr to search.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is contained within the network; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainedBy([CanBeNull] this DbFunctions _, IPAddress inet, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) is contained within another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to locate.</param>
        /// <param name="other">The cidr to search.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) is contained within the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainedBy([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is contained within or equal to another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to locate.</param>
        /// <param name="other">The inet to search.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is contained within or equal to the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainedByOrEqual([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> is contained within or equal to a network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to locate.</param>
        /// <param name="other">The cidr to search.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> is contained within or equal to the network; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainedByOrEqual([CanBeNull] this DbFunctions _, IPAddress inet, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) is contained within or equal to another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to locate.</param>
        /// <param name="other">The cidr to search.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) is contained within or equal to the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainedByOrEqual([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> contains another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The IP address to search.</param>
        /// <param name="other">The IP address to locate.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> contains the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool Contains([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether a network contains another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The network to search.</param>
        /// <param name="other">The IP address to locate.</param>
        /// <returns>
        /// True if the network contains the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool Contains([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) contains another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to search.</param>
        /// <param name="other">The cidr to locate.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) contains the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool Contains([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> contains or is equal to another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The IP address to search.</param>
        /// <param name="other">The IP address to locate.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> contains or is equal to the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainsOrEqual([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether a network contains or is equal to another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The network to search.</param>
        /// <param name="other">The IP address to locate.</param>
        /// <returns>
        /// True if the network contains or is equal to the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainsOrEqual([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) contains or is equal to another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to search.</param>
        /// <param name="other">The cidr to locate.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) contains or is equal to the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainsOrEqual([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> contains or is contained by another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The IP address to search.</param>
        /// <param name="other">The IP address to locate.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> contains or is contained by the other <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainsOrContainedBy([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether a network contains or is contained by an <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The network to search.</param>
        /// <param name="other">The IP address to locate.</param>
        /// <returns>
        /// True if the network contains or is contained by the <see cref="IPAddress"/>; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainsOrContainedBy([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an <see cref="IPAddress"/> contains or is contained by a network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The IP address to search.</param>
        /// <param name="other">The network to locate.</param>
        /// <returns>
        /// True if the <see cref="IPAddress"/> contains or is contained by the network; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainsOrContainedBy([CanBeNull] this DbFunctions _, IPAddress inet, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Determines whether an (IPAddress Address, int Subnet) contains or is contained by another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to search.</param>
        /// <param name="other">The cidr to locate.</param>
        /// <returns>
        /// True if the (IPAddress Address, int Subnet) contains or is contained by the other (IPAddress Address, int Subnet); otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool ContainsOrContainedBy([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        #endregion

        #region BitwiseOperators

        /// <summary>
        /// Computes the bitwise NOT operation on an <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to negate.</param>
        /// <returns>
        /// The result of the bitwise NOT operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress BitwiseNot([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise NOT operation on an (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to negate.</param>
        /// <returns>
        /// The result of the bitwise NOT operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) BitwiseNot([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise NOT operation on an <see cref="PhysicalAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macaddr">The macaddr to negate.</param>
        /// <returns>
        /// The result of the bitwise NOT operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static PhysicalAddress BitwiseNot([CanBeNull] this DbFunctions _, PhysicalAddress macaddr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise AND of two <see cref="IPAddress"/> instances.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The left-hand inet.</param>
        /// <param name="other">The right-hand inet.</param>
        /// <returns>
        /// The result of the bitwise AND operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress BitwiseAnd([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise AND of two (IPAddress Address, int Subnet) instances.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The left-hand cidr.</param>
        /// <param name="other">The right-hand cidr.</param>
        /// <returns>
        /// The result of the bitwise AND operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) BitwiseAnd([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise AND of two <see cref="PhysicalAddress"/> instances.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macaddr">The left-hand macaddr.</param>
        /// <param name="other">The right-hand macaddr.</param>
        /// <returns>
        /// The result of the bitwise AND operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static PhysicalAddress BitwiseAnd([CanBeNull] this DbFunctions _, PhysicalAddress macaddr, PhysicalAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise OR of two <see cref="IPAddress"/> instances.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The left-hand inet.</param>
        /// <param name="other">The right-hand inet.</param>
        /// <returns>
        /// The result of the bitwise OR operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress BitwiseOr([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise OR of two (IPAddress Address, int Subnet) instances.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The left-hand cidr.</param>
        /// <param name="other">The right-hand cidr.</param>
        /// <returns>
        /// The result of the bitwise OR operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) BitwiseOr([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Computes the bitwise OR of two <see cref="PhysicalAddress"/> instances.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macaddr">The left-hand macaddr.</param>
        /// <param name="other">The right-hand macaddr.</param>
        /// <returns>
        /// The result of the bitwise OR operation.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static PhysicalAddress BitwiseOr([CanBeNull] this DbFunctions _, PhysicalAddress macaddr, PhysicalAddress other)
            => throw ClientEvaluationNotSupportedException();

        #endregion

        #region ArithmeticOperators

        /// <summary>
        /// Adds the <paramref name="value"/> to the <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet.</param>
        /// <param name="value">The value to add.</param>
        /// <returns>
        /// The <see cref="IPAddress"/> augmented by the <paramref name="value"/>.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress Add([CanBeNull] this DbFunctions _, IPAddress inet, int value)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Adds the <paramref name="value"/> to the (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr.</param>
        /// <param name="value">The value to add.</param>
        /// <returns>
        /// The (IPAddress Address, int Subnet) augmented by the <paramref name="value"/>.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) Add([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, int value)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Subtracts the <paramref name="value"/> from the <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet.</param>
        /// <param name="value">The value to subtract.</param>
        /// <returns>
        /// The <see cref="IPAddress"/> augmented by the <paramref name="value"/>.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress Subtract([CanBeNull] this DbFunctions _, IPAddress inet, int value)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Subtracts the <paramref name="value"/> from the (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The inet.</param>
        /// <param name="value">The value to subtract.</param>
        /// <returns>
        /// The (IPAddress Address, int Subnet) augmented by the <paramref name="value"/>.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) Subtract([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, int value)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Subtracts one <see cref="IPAddress"/> from another <see cref="IPAddress"/>.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet from which to subtract.</param>
        /// <param name="other">The inet to subtract.</param>
        /// <returns>
        /// The numeric difference between the two given addresses.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static int Subtract([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Subtracts one (IPAddress Address, int Subnet) from another (IPAddress Address, int Subnet).
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr from which to subtract.</param>
        /// <param name="other">The cidr to subtract.</param>
        /// <returns>
        /// The difference between the two addresses.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static int Subtract([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        #endregion

        #region Functions

        /// <summary>
        /// Returns the abbreviated display format as text.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to abbreviate.</param>
        /// <returns>
        /// The abbreviated display format as text.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static string Abbreviate([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Returns the abbreviated display format as text.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to abbreviate.</param>
        /// <returns>
        /// The abbreviated display format as text.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static string Abbreviate([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Returns the broadcast address for a network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet used to derive the broadcast address.</param>
        /// <returns>
        /// The broadcast address for a network.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress Broadcast([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Returns the broadcast address for a network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr used to derive the broadcast address.</param>
        /// <returns>
        /// The broadcast address for a network.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress Broadcast([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the family of an address; 4 for IPv4, 6 for IPv6.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet used to derive the family.</param>
        /// <returns>
        /// The family of an address; 4 for IPv4, 6 for IPv6.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static int Family([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the family of an address; 4 for IPv4, 6 for IPv6.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr used to derive the family.</param>
        /// <returns>
        /// The family of an address; 4 for IPv4, 6 for IPv6.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static int Family([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the host (i.e. the IP address) as text.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet from which to extract the host.</param>
        /// <returns>
        /// The host (i.e. the IP address) as text.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static string Host([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the host (i.e. the IP address) as text.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr from which to extract the host.</param>
        /// <returns>
        /// The host (i.e. the IP address) as text.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static string Host([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Constructs the host mask for the network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet used to construct the host mask.</param>
        /// <returns>
        /// The constructed host mask.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress HostMask([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Constructs the host mask for the network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr used to construct the host mask.</param>
        /// <returns>
        /// The constructed host mask.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress HostMask([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the length of the subnet mask.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet used to extract the subnet length.</param>
        /// <returns>
        /// The length of the subnet mask.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static int MaskLength([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the length of the subnet mask.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr used to extract the subnet length.</param>
        /// <returns>
        /// The length of the subnet mask.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static int MaskLength([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Constructs the subnet mask for the network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet used to construct the subnet mask.</param>
        /// <returns>
        /// The subnet mask for the network.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress Netmask([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Constructs the subnet mask for the network.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr used to construct the subnet mask.</param>
        /// <returns>
        /// The subnet mask for the network.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress Netmask([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the network part of the address.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet used to extract the network.</param>
        /// <returns>
        /// The network part of the address.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) Network([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the network part of the address.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr used to extract the network.</param>
        /// <returns>
        /// The network part of the address.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) Network([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Sets the length of the subnet mask.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to modify.</param>
        /// <param name="length">The subnet mask length to set.</param>
        /// <returns>
        /// The network with a subnet mask of the specified length.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static IPAddress SetMaskLength([CanBeNull] this DbFunctions _, IPAddress inet, int length)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Sets the length of the subnet mask.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to modify.</param>
        /// <param name="length">The subnet mask length to set.</param>
        /// <returns>
        /// The network with a subnet mask of the specified length.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) SetMaskLength([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, int length)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the IP address and subnet mask as text.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The inet to extract as text.</param>
        /// <returns>
        /// The IP address and subnet mask as text.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static string Text([CanBeNull] this DbFunctions _, IPAddress inet)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Extracts the IP address and subnet mask as text.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The cidr to extract as text.</param>
        /// <returns>
        /// The IP address and subnet mask as text.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static string Text([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Tests if the addresses are in the same family.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The primary inet.</param>
        /// <param name="other">The other inet.</param>
        /// <returns>
        /// True if the addresses are in the same family; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool SameFamily([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Tests if the addresses are in the same family.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The primary cidr.</param>
        /// <param name="other">The other cidr.</param>
        /// <returns>
        /// True if the addresses are in the same family; otherwise, false.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static bool SameFamily([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Constructs the smallest network which includes both of the given networks.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="inet">The first inet.</param>
        /// <param name="other">The second inet.</param>
        /// <returns>
        /// The smallest network which includes both of the given networks.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) Merge([CanBeNull] this DbFunctions _, IPAddress inet, IPAddress other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Constructs the smallest network which includes both of the given networks.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="cidr">The first cidr.</param>
        /// <param name="other">The second cidr.</param>
        /// <returns>
        /// The smallest network which includes both of the given networks.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static (IPAddress Address, int Subnet) Merge([CanBeNull] this DbFunctions _, (IPAddress Address, int Subnet) cidr, (IPAddress Address, int Subnet) other)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Sets the last 3 bytes of the MAC address to zero. For macaddr8, the last 5 bytes are set to zero.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macAddress">The MAC address to truncate.</param>
        /// <returns>
        /// The MAC address with the last 3 bytes set to zero. For macaddr8, the last 5 bytes are set to zero.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static PhysicalAddress Truncate([CanBeNull] this DbFunctions _, PhysicalAddress macAddress)
            => throw ClientEvaluationNotSupportedException();

        /// <summary>
        /// Sets the 7th bit to one, also known as modified EUI-64, for inclusion in an IPv6 address.
        /// </summary>
        /// <param name="_">The <see cref="DbFunctions"/> instance.</param>
        /// <param name="macAddress">The MAC address to modify.</param>
        /// <returns>
        /// The MAC address with the 7th bit set to one.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// This method is only intended for use via SQL translation as part of an EF Core LINQ query.
        /// </exception>
        public static PhysicalAddress Set7BitMac8([CanBeNull] this DbFunctions _, PhysicalAddress macAddress)
            => throw ClientEvaluationNotSupportedException();

        #endregion

        #region Utilities

        /// <summary>
        /// Helper method to throw a <see cref="NotSupportedException"/> with the name of the throwing method.
        /// </summary>
        /// <param name="method">The method that throws the exception.</param>
        /// <returns>
        /// A <see cref="NotSupportedException"/>.
        /// </returns>
        [NotNull]
        static NotSupportedException ClientEvaluationNotSupportedException([CallerMemberName] string method = default)
            => new NotSupportedException($"{method} is only intended for use via SQL translation as part of an EF Core LINQ query.");

        #endregion
    }
}
