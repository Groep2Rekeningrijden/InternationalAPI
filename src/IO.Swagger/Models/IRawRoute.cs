﻿/*
 * Rekeningrijden Belgium API
 *
 * The international API for Rekeningrijden Belgium
 *
 * OpenAPI spec version: 0.4.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Collections.Generic;

namespace IO.Swagger.Models
{
    public interface IRawRoute
    {
        List<Point> Points { get; set; }
        Vehicle Vehicle { get; set; }

        bool Equals(object obj);
        bool Equals(RawRoute other);
        int GetHashCode();
        string ToJson();
        string ToString();
    }
}