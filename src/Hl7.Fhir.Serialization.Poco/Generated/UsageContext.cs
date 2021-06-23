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
  /// JSON Serialization Extensions for UsageContext
  /// </summary>
  public static class UsageContextSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR UsageContext into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.UsageContext current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: UsageContext, Export: UsageContext, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("code", current.Code, writer, options);

      if (current.Value != null)
      {
        switch (current.Value)
        {
          case Hl7.Fhir.Model.CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("valueCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.Quantity v_Quantity:
            writer.WritePropertyName("valueQuantity");
            v_Quantity.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.Range v_Range:
            writer.WritePropertyName("valueRange");
            v_Range.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            writer.WritePropertyName("valueReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR UsageContext
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.UsageContext current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"UsageContext >>> UsageContext.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"UsageContext: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR UsageContext
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.UsageContext current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          current.Code = new Hl7.Fhir.Model.Coding();
          ((Hl7.Fhir.Model.Coding)current.Code).DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          current.Value = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          current.Value = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueRange":
          current.Value = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueReference":
          current.Value = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Value).DeserializeJson(ref reader, options);
          break;

        // Complex: UsageContext, Export: UsageContext, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class UsageContextJsonConverter : JsonConverter<Hl7.Fhir.Model.UsageContext>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.UsageContext value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.UsageContext Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.UsageContext();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
