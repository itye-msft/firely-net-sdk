// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Serialization.Poco
{
  /// <summary>
  /// JSON Serialization Extensions for DataRequirement
  /// </summary>
  public static class DataRequirementSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR DataRequirement into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.DataRequirement current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: DataRequirement, Export: DataRequirement, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("type",current.TypeElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("profile",current.ProfileElement,writer,options);

      if (current.Subject != null)
      {
        switch (current.Subject)
        {
          case Hl7.Fhir.Model.CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("subjectCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            writer.WritePropertyName("subjectReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      JsonStreamUtilities.SerializePrimitiveProperty("mustSupport",current.MustSupportElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("codeFilter", current.CodeFilter, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("dateFilter", current.DateFilter, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("limit",current.LimitElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("sort", current.Sort, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.DataRequirement current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"DataRequirement >>> DataRequirement.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"DataRequirement: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.DataRequirement current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.FHIRAllTypes>();
            reader.Skip();
          }
          else
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.FHIRAllTypes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.FHIRAllTypes>(reader.GetString()));
          }
          break;

        case "_type":
          if (current.TypeElement == null) { current.TypeElement = new Code<Hl7.Fhir.Model.FHIRAllTypes>(); }
          ((Hl7.Fhir.Model.Element)current.TypeElement).DeserializeJson(ref reader, options);
          break;

        case "profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"DataRequirement error reading 'profile' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ProfileElement = new List<Canonical>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.ProfileElement.Add(new Canonical());
              reader.Skip();
            }
            else
            {
              current.ProfileElement.Add(new Canonical(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"DataRequirement error reading 'profile' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ProfileElement.Count == 0)
          {
            current.ProfileElement = null;
          }
          break;

        case "_profile":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"DataRequirement error reading 'profile' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_profile = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_profile >= current.ProfileElement.Count)
            {
              current.ProfileElement.Add(new Canonical());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.ProfileElement[i_profile++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"DataRequirement error reading 'profile' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "subjectCodeableConcept":
          current.Subject = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "subjectReference":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "mustSupport":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"DataRequirement error reading 'mustSupport' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.MustSupportElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.MustSupportElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.MustSupportElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"DataRequirement error reading 'mustSupport' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.MustSupportElement.Count == 0)
          {
            current.MustSupportElement = null;
          }
          break;

        case "_mustSupport":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"DataRequirement error reading 'mustSupport' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_mustSupport = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_mustSupport >= current.MustSupportElement.Count)
            {
              current.MustSupportElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.MustSupportElement[i_mustSupport++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"DataRequirement error reading 'mustSupport' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "codeFilter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"DataRequirement error reading 'codeFilter' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.CodeFilter = new List<DataRequirement.CodeFilterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.DataRequirement.CodeFilterComponent v_CodeFilter = new Hl7.Fhir.Model.DataRequirement.CodeFilterComponent();
            v_CodeFilter.DeserializeJson(ref reader, options);
            current.CodeFilter.Add(v_CodeFilter);

            if (!reader.Read())
            {
              throw new JsonException($"DataRequirement error reading 'codeFilter' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.CodeFilter.Count == 0)
          {
            current.CodeFilter = null;
          }
          break;

        case "dateFilter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"DataRequirement error reading 'dateFilter' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.DateFilter = new List<DataRequirement.DateFilterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.DataRequirement.DateFilterComponent v_DateFilter = new Hl7.Fhir.Model.DataRequirement.DateFilterComponent();
            v_DateFilter.DeserializeJson(ref reader, options);
            current.DateFilter.Add(v_DateFilter);

            if (!reader.Read())
            {
              throw new JsonException($"DataRequirement error reading 'dateFilter' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DateFilter.Count == 0)
          {
            current.DateFilter = null;
          }
          break;

        case "limit":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.LimitElement = new PositiveInt();
            reader.Skip();
          }
          else
          {
            current.LimitElement = new PositiveInt(reader.GetInt32());
          }
          break;

        case "_limit":
          if (current.LimitElement == null) { current.LimitElement = new PositiveInt(); }
          ((Hl7.Fhir.Model.Element)current.LimitElement).DeserializeJson(ref reader, options);
          break;

        case "sort":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"DataRequirement error reading 'sort' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Sort = new List<DataRequirement.SortComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.DataRequirement.SortComponent v_Sort = new Hl7.Fhir.Model.DataRequirement.SortComponent();
            v_Sort.DeserializeJson(ref reader, options);
            current.Sort.Add(v_Sort);

            if (!reader.Read())
            {
              throw new JsonException($"DataRequirement error reading 'sort' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Sort.Count == 0)
          {
            current.Sort = null;
          }
          break;

        // Complex: DataRequirement, Export: DataRequirement, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR DataRequirement#CodeFilter into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.DataRequirement.CodeFilterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: DataRequirement#CodeFilter, Export: CodeFilterComponent, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("path",current.PathElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("searchParam",current.SearchParamElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("valueSet",current.ValueSetElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("code", current.Code, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#CodeFilter
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.DataRequirement.CodeFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"DataRequirement.CodeFilterComponent >>> DataRequirement#CodeFilter.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"DataRequirement.CodeFilterComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#CodeFilter
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.DataRequirement.CodeFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "path":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PathElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.PathElement = new FhirString(reader.GetString());
          }
          break;

        case "_path":
          if (current.PathElement == null) { current.PathElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.PathElement).DeserializeJson(ref reader, options);
          break;

        case "searchParam":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SearchParamElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.SearchParamElement = new FhirString(reader.GetString());
          }
          break;

        case "_searchParam":
          if (current.SearchParamElement == null) { current.SearchParamElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.SearchParamElement).DeserializeJson(ref reader, options);
          break;

        case "valueSet":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ValueSetElement = new Canonical();
            reader.Skip();
          }
          else
          {
            current.ValueSetElement = new Canonical(reader.GetString());
          }
          break;

        case "_valueSet":
          if (current.ValueSetElement == null) { current.ValueSetElement = new Canonical(); }
          ((Hl7.Fhir.Model.Element)current.ValueSetElement).DeserializeJson(ref reader, options);
          break;

        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"CodeFilterComponent error reading 'code' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Code = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Coding v_Code = new Hl7.Fhir.Model.Coding();
            v_Code.DeserializeJson(ref reader, options);
            current.Code.Add(v_Code);

            if (!reader.Read())
            {
              throw new JsonException($"CodeFilterComponent error reading 'code' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Code.Count == 0)
          {
            current.Code = null;
          }
          break;

        // Complex: codeFilter, Export: CodeFilterComponent, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR DataRequirement#DateFilter into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.DataRequirement.DateFilterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: DataRequirement#DateFilter, Export: DateFilterComponent, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("path",current.PathElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("searchParam",current.SearchParamElement,writer,options);

      if (current.Value != null)
      {
        switch (current.Value)
        {
          case Hl7.Fhir.Model.FhirDateTime v_FhirDateTime:
            JsonStreamUtilities.SerializePrimitiveProperty("valueDateTime",v_FhirDateTime,writer,options);
            break;
          case Hl7.Fhir.Model.Period v_Period:
            writer.WritePropertyName("valuePeriod");
            v_Period.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.Duration v_Duration:
            writer.WritePropertyName("valueDuration");
            v_Duration.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#DateFilter
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.DataRequirement.DateFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"DataRequirement.DateFilterComponent >>> DataRequirement#DateFilter.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"DataRequirement.DateFilterComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#DateFilter
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.DataRequirement.DateFilterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "path":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PathElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.PathElement = new FhirString(reader.GetString());
          }
          break;

        case "_path":
          if (current.PathElement == null) { current.PathElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.PathElement).DeserializeJson(ref reader, options);
          break;

        case "searchParam":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SearchParamElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.SearchParamElement = new FhirString(reader.GetString());
          }
          break;

        case "_searchParam":
          if (current.SearchParamElement == null) { current.SearchParamElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.SearchParamElement).DeserializeJson(ref reader, options);
          break;

        case "valueDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Value = new FhirDateTime(reader.GetString());
          }
          break;

        case "_valueDateTime":
          if (current.Value == null) { current.Value = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valuePeriod":
          current.Value = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueDuration":
          current.Value = new Hl7.Fhir.Model.Duration();
          ((Hl7.Fhir.Model.Duration)current.Value).DeserializeJson(ref reader, options);
          break;

        // Complex: dateFilter, Export: DateFilterComponent, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR DataRequirement#Sort into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.DataRequirement.SortComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: DataRequirement#Sort, Export: SortComponent, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("path",current.PathElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("direction",current.DirectionElement,writer,options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#Sort
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.DataRequirement.SortComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"DataRequirement.SortComponent >>> DataRequirement#Sort.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"DataRequirement.SortComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR DataRequirement#Sort
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.DataRequirement.SortComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "path":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PathElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.PathElement = new FhirString(reader.GetString());
          }
          break;

        case "_path":
          if (current.PathElement == null) { current.PathElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.PathElement).DeserializeJson(ref reader, options);
          break;

        case "direction":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DirectionElement = new Code<Hl7.Fhir.Model.DataRequirement.SortDirection>();
            reader.Skip();
          }
          else
          {
            current.DirectionElement = new Code<Hl7.Fhir.Model.DataRequirement.SortDirection>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DataRequirement.SortDirection>(reader.GetString()));
          }
          break;

        case "_direction":
          if (current.DirectionElement == null) { current.DirectionElement = new Code<Hl7.Fhir.Model.DataRequirement.SortDirection>(); }
          ((Hl7.Fhir.Model.Element)current.DirectionElement).DeserializeJson(ref reader, options);
          break;

        // Complex: sort, Export: SortComponent, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class DataRequirementJsonConverter : JsonConverter<Hl7.Fhir.Model.DataRequirement>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.DataRequirement value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.DataRequirement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.DataRequirement();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
