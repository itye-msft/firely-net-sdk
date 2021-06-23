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
  /// JSON Serialization Extensions for Address
  /// </summary>
  public static class AddressSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Address into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Address current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: Address, Export: Address, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("use",current.UseElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("type",current.TypeElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("text",current.TextElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("line",current.LineElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("city",current.CityElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("district",current.DistrictElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("state",current.StateElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("postalCode",current.PostalCodeElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("country",current.CountryElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("period", current.Period, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Address
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Address current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Address >>> Address.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Address: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Address
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Address current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "use":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.UseElement = new Code<Hl7.Fhir.Model.Address.AddressUse>();
            reader.Skip();
          }
          else
          {
            current.UseElement = new Code<Hl7.Fhir.Model.Address.AddressUse>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Address.AddressUse>(reader.GetString()));
          }
          break;

        case "_use":
          if (current.UseElement == null) { current.UseElement = new Code<Hl7.Fhir.Model.Address.AddressUse>(); }
          ((Hl7.Fhir.Model.Element)current.UseElement).DeserializeJson(ref reader, options);
          break;

        case "type":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.Address.AddressType>();
            reader.Skip();
          }
          else
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.Address.AddressType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Address.AddressType>(reader.GetString()));
          }
          break;

        case "_type":
          if (current.TypeElement == null) { current.TypeElement = new Code<Hl7.Fhir.Model.Address.AddressType>(); }
          ((Hl7.Fhir.Model.Element)current.TypeElement).DeserializeJson(ref reader, options);
          break;

        case "text":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TextElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.TextElement = new FhirString(reader.GetString());
          }
          break;

        case "_text":
          if (current.TextElement == null) { current.TextElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.TextElement).DeserializeJson(ref reader, options);
          break;

        case "line":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Address error reading 'line' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.LineElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.LineElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.LineElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"Address error reading 'line' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.LineElement.Count == 0)
          {
            current.LineElement = null;
          }
          break;

        case "_line":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Address error reading 'line' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_line = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_line >= current.LineElement.Count)
            {
              current.LineElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.LineElement[i_line++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"Address error reading 'line' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "city":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CityElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.CityElement = new FhirString(reader.GetString());
          }
          break;

        case "_city":
          if (current.CityElement == null) { current.CityElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.CityElement).DeserializeJson(ref reader, options);
          break;

        case "district":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DistrictElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DistrictElement = new FhirString(reader.GetString());
          }
          break;

        case "_district":
          if (current.DistrictElement == null) { current.DistrictElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DistrictElement).DeserializeJson(ref reader, options);
          break;

        case "state":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StateElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.StateElement = new FhirString(reader.GetString());
          }
          break;

        case "_state":
          if (current.StateElement == null) { current.StateElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.StateElement).DeserializeJson(ref reader, options);
          break;

        case "postalCode":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PostalCodeElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.PostalCodeElement = new FhirString(reader.GetString());
          }
          break;

        case "_postalCode":
          if (current.PostalCodeElement == null) { current.PostalCodeElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.PostalCodeElement).DeserializeJson(ref reader, options);
          break;

        case "country":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CountryElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.CountryElement = new FhirString(reader.GetString());
          }
          break;

        case "_country":
          if (current.CountryElement == null) { current.CountryElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.CountryElement).DeserializeJson(ref reader, options);
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        // Complex: Address, Export: Address, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class AddressJsonConverter : JsonConverter<Hl7.Fhir.Model.Address>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Address value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Address Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Address();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
