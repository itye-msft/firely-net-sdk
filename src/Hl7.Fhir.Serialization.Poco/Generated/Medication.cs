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
  /// JSON Serialization Extensions for Medication
  /// </summary>
  public static class MedicationSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Medication into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Medication current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Medication");
      // Complex: Medication, Export: Medication, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("code", current.Code, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("manufacturer", current.Manufacturer, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("form", current.Form, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("amount", current.Amount, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("ingredient", current.Ingredient, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("batch", current.Batch, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Medication
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Medication current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Medication >>> Medication.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Medication: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Medication
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Medication current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Medication error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"Medication error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Code).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Medication.MedicationStatusCodes>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.Medication.MedicationStatusCodes>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          current.Manufacturer = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Manufacturer).DeserializeJson(ref reader, options);
          break;

        case "form":
          current.Form = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Form).DeserializeJson(ref reader, options);
          break;

        case "amount":
          current.Amount = new Hl7.Fhir.Model.Ratio();
          ((Hl7.Fhir.Model.Ratio)current.Amount).DeserializeJson(ref reader, options);
          break;

        case "ingredient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Medication error reading 'ingredient' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Ingredient = new List<Medication.IngredientComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Medication.IngredientComponent v_Ingredient = new Hl7.Fhir.Model.Medication.IngredientComponent();
            v_Ingredient.DeserializeJson(ref reader, options);
            current.Ingredient.Add(v_Ingredient);

            if (!reader.Read())
            {
              throw new JsonException($"Medication error reading 'ingredient' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Ingredient.Count == 0)
          {
            current.Ingredient = null;
          }
          break;

        case "batch":
          current.Batch = new Hl7.Fhir.Model.Medication.BatchComponent();
          ((Hl7.Fhir.Model.Medication.BatchComponent)current.Batch).DeserializeJson(ref reader, options);
          break;

        // Complex: Medication, Export: Medication, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Medication#Ingredient into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Medication.IngredientComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Medication#Ingredient, Export: IngredientComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.Item != null)
      {
        switch (current.Item)
        {
          case Hl7.Fhir.Model.CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("itemCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            writer.WritePropertyName("itemReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      JsonStreamUtilities.SerializePrimitiveProperty("isActive",current.IsActiveElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("strength", current.Strength, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Medication#Ingredient
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Medication.IngredientComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Medication.IngredientComponent >>> Medication#Ingredient.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Medication.IngredientComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Medication#Ingredient
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Medication.IngredientComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "itemCodeableConcept":
          current.Item = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Item).DeserializeJson(ref reader, options);
          break;

        case "itemReference":
          current.Item = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Item).DeserializeJson(ref reader, options);
          break;

        case "isActive":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.IsActiveElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.IsActiveElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_isActive":
          if (current.IsActiveElement == null) { current.IsActiveElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.IsActiveElement).DeserializeJson(ref reader, options);
          break;

        case "strength":
          current.Strength = new Hl7.Fhir.Model.Ratio();
          ((Hl7.Fhir.Model.Ratio)current.Strength).DeserializeJson(ref reader, options);
          break;

        // Complex: ingredient, Export: IngredientComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Medication#Batch into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Medication.BatchComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Medication#Batch, Export: BatchComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("lotNumber",current.LotNumberElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("expirationDate",current.ExpirationDateElement,writer,options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Medication#Batch
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Medication.BatchComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Medication.BatchComponent >>> Medication#Batch.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Medication.BatchComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Medication#Batch
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Medication.BatchComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "lotNumber":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.LotNumberElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.LotNumberElement = new FhirString(reader.GetString());
          }
          break;

        case "_lotNumber":
          if (current.LotNumberElement == null) { current.LotNumberElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.LotNumberElement).DeserializeJson(ref reader, options);
          break;

        case "expirationDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ExpirationDateElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.ExpirationDateElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_expirationDate":
          if (current.ExpirationDateElement == null) { current.ExpirationDateElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.ExpirationDateElement).DeserializeJson(ref reader, options);
          break;

        // Complex: batch, Export: BatchComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicationJsonConverter : JsonConverter<Hl7.Fhir.Model.Medication>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Medication value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Medication Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Medication();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
