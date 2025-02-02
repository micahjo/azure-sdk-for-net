// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> the type of setting period. </summary>
    public readonly partial struct MetricPeriodType : IEquatable<MetricPeriodType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="MetricPeriodType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricPeriodType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoDetectValue = "AutoDetect";
        private const string AssignValueValue = "AssignValue";

        /// <summary> AutoDetect. </summary>
        public static MetricPeriodType AutoDetect { get; } = new MetricPeriodType(AutoDetectValue);
        /// <summary> AssignValue. </summary>
        public static MetricPeriodType AssignValue { get; } = new MetricPeriodType(AssignValueValue);
        /// <summary> Determines if two <see cref="MetricPeriodType"/> values are the same. </summary>
        public static bool operator ==(MetricPeriodType left, MetricPeriodType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricPeriodType"/> values are not the same. </summary>
        public static bool operator !=(MetricPeriodType left, MetricPeriodType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MetricPeriodType"/>. </summary>
        public static implicit operator MetricPeriodType(string value) => new MetricPeriodType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricPeriodType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricPeriodType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
