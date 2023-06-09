/*
 * Rekeningrijden Belgium API
 *
 * The international API for Rekeningrijden Belgium
 *
 * OpenAPI spec version: 0.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models;

/// <summary>
/// A point with latitute, longitude and timestamp, including timezone data
/// </summary>
[DataContract]
public partial class Point : IEquatable<Point>
{ 
    /// <summary>
    /// Gets or Sets Lat
    /// </summary>

    [DataMember(Name="lat")]
    public float? Lat { get; set; }

    /// <summary>
    /// Gets or Sets Lon
    /// </summary>

    [DataMember(Name="lon")]
    public float? Lon { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>

    [DataMember(Name="time")]
    public DateTime? Time { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Point {\n");
        sb.Append("  Lat: ").Append(Lat).Append("\n");
        sb.Append("  Lon: ").Append(Lon).Append("\n");
        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Point)obj);
    }

    /// <summary>
    /// Returns true if Point instances are equal
    /// </summary>
    /// <param name="other">Instance of Point to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Point other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;

        return 
            (
                Lat == other.Lat ||
                Lat != null &&
                Lat.Equals(other.Lat)
            ) && 
            (
                Lon == other.Lon ||
                Lon != null &&
                Lon.Equals(other.Lon)
            ) && 
            (
                Time == other.Time ||
                Time != null &&
                Time.Equals(other.Time)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            var hashCode = 41;
            // Suitable nullity checks etc, of course :)
            if (Lat != null)
                hashCode = hashCode * 59 + Lat.GetHashCode();
            if (Lon != null)
                hashCode = hashCode * 59 + Lon.GetHashCode();
            if (Time != null)
                hashCode = hashCode * 59 + Time.GetHashCode();
            return hashCode;
        }
    }

    #region Operators
#pragma warning disable 1591

    public static bool operator ==(Point left, Point right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Point left, Point right)
    {
        return !Equals(left, right);
    }

#pragma warning restore 1591
    #endregion Operators
}