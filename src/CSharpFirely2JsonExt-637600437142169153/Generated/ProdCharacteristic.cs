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
  /// JSON Serialization Extensions for ProdCharacteristic
  /// </summary>
  public static class ProdCharacteristicSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR ProdCharacteristic into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.ProdCharacteristic current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: ProdCharacteristic, Export: ProdCharacteristic, Base: BackboneElement (BackboneType)
      ((Hl7.Fhir.Model.BackboneType)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("height", current.Height, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("width", current.Width, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("depth", current.Depth, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("weight", current.Weight, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("nominalVolume", current.NominalVolume, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("externalDiameter", current.ExternalDiameter, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("shape",current.ShapeElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("color",current.ColorElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("imprint",current.ImprintElement,writer,options);

      if ((current.Image != null) && (current.Image.Count != 0))
      {
        writer.WritePropertyName("image");
        writer.WriteStartArray();
        foreach (Attachment val in current.Image)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      JsonStreamUtilities.SerializeComplexProperty("scoring", current.Scoring, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ProdCharacteristic
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.ProdCharacteristic current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"ProdCharacteristic >>> ProdCharacteristic.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"ProdCharacteristic: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ProdCharacteristic
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.ProdCharacteristic current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "height":
          current.Height = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Height).DeserializeJson(ref reader, options);
          break;

        case "width":
          current.Width = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Width).DeserializeJson(ref reader, options);
          break;

        case "depth":
          current.Depth = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Depth).DeserializeJson(ref reader, options);
          break;

        case "weight":
          current.Weight = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Weight).DeserializeJson(ref reader, options);
          break;

        case "nominalVolume":
          current.NominalVolume = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.NominalVolume).DeserializeJson(ref reader, options);
          break;

        case "externalDiameter":
          current.ExternalDiameter = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.ExternalDiameter).DeserializeJson(ref reader, options);
          break;

        case "shape":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ShapeElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ShapeElement = new FhirString(reader.GetString());
          }
          break;

        case "_shape":
          if (current.ShapeElement == null) { current.ShapeElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ShapeElement).DeserializeJson(ref reader, options);
          break;

        case "color":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ProdCharacteristic error reading 'color' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ColorElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.ColorElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.ColorElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"ProdCharacteristic error reading 'color' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ColorElement.Count == 0)
          {
            current.ColorElement = null;
          }
          break;

        case "_color":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ProdCharacteristic error reading 'color' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_color = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_color >= current.ColorElement.Count)
            {
              current.ColorElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.ColorElement[i_color++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"ProdCharacteristic error reading 'color' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "imprint":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ProdCharacteristic error reading 'imprint' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ImprintElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.ImprintElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.ImprintElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"ProdCharacteristic error reading 'imprint' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ImprintElement.Count == 0)
          {
            current.ImprintElement = null;
          }
          break;

        case "_imprint":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ProdCharacteristic error reading 'imprint' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_imprint = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_imprint >= current.ImprintElement.Count)
            {
              current.ImprintElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.ImprintElement[i_imprint++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"ProdCharacteristic error reading 'imprint' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "image":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ProdCharacteristic error reading 'image' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Image = new List<Attachment>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Attachment v_Image = new Hl7.Fhir.Model.Attachment();
            v_Image.DeserializeJson(ref reader, options);
            current.Image.Add(v_Image);

            if (!reader.Read())
            {
              throw new JsonException($"ProdCharacteristic error reading 'image' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Image.Count == 0)
          {
            current.Image = null;
          }
          break;

        case "scoring":
          current.Scoring = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Scoring).DeserializeJson(ref reader, options);
          break;

        // Complex: ProdCharacteristic, Export: ProdCharacteristic, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneType)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ProdCharacteristicJsonConverter : JsonConverter<Hl7.Fhir.Model.ProdCharacteristic>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.ProdCharacteristic value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.ProdCharacteristic Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.ProdCharacteristic();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
