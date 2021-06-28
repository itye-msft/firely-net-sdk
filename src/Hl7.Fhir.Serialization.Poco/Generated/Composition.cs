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
  /// JSON Serialization Extensions for Composition
  /// </summary>
  public static class CompositionSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Composition into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Composition current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Composition");
      // Complex: Composition, Export: Composition, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("category", current.Category, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("subject", current.Subject, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("encounter", current.Encounter, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("date",current.DateElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("author", current.Author, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("title",current.TitleElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("confidentiality",current.ConfidentialityElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("attester", current.Attester, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("custodian", current.Custodian, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("relatesTo", current.RelatesTo, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("event", current.Event, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("section", current.Section, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Composition current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Composition >>> Composition.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Composition: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Composition current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          current.Identifier = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.Identifier).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.CompositionStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.CompositionStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.CompositionStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.CompositionStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Composition error reading 'category' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Category = new Hl7.Fhir.Model.CodeableConcept();
            v_Category.DeserializeJson(ref reader, options);
            current.Category.Add(v_Category);

            if (!reader.Read())
            {
              throw new JsonException($"Composition error reading 'category' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Category.Count == 0)
          {
            current.Category = null;
          }
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "encounter":
          current.Encounter = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Encounter).DeserializeJson(ref reader, options);
          break;

        case "date":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DateElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.DateElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_date":
          if (current.DateElement == null) { current.DateElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.DateElement).DeserializeJson(ref reader, options);
          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Composition error reading 'author' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Author = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Author = new Hl7.Fhir.Model.ResourceReference();
            v_Author.DeserializeJson(ref reader, options);
            current.Author.Add(v_Author);

            if (!reader.Read())
            {
              throw new JsonException($"Composition error reading 'author' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Author.Count == 0)
          {
            current.Author = null;
          }
          break;

        case "title":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TitleElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.TitleElement = new FhirString(reader.GetString());
          }
          break;

        case "_title":
          if (current.TitleElement == null) { current.TitleElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.TitleElement).DeserializeJson(ref reader, options);
          break;

        case "confidentiality":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ConfidentialityElement = new Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>();
            reader.Skip();
          }
          else
          {
            current.ConfidentialityElement = new Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>(reader.GetString()));
          }
          break;

        case "_confidentiality":
          if (current.ConfidentialityElement == null) { current.ConfidentialityElement = new Code<Hl7.Fhir.Model.Composition.v3_ConfidentialityClassification>(); }
          ((Hl7.Fhir.Model.Element)current.ConfidentialityElement).DeserializeJson(ref reader, options);
          break;

        case "attester":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Composition error reading 'attester' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Attester = new List<Composition.AttesterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Composition.AttesterComponent v_Attester = new Hl7.Fhir.Model.Composition.AttesterComponent();
            v_Attester.DeserializeJson(ref reader, options);
            current.Attester.Add(v_Attester);

            if (!reader.Read())
            {
              throw new JsonException($"Composition error reading 'attester' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Attester.Count == 0)
          {
            current.Attester = null;
          }
          break;

        case "custodian":
          current.Custodian = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Custodian).DeserializeJson(ref reader, options);
          break;

        case "relatesTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Composition error reading 'relatesTo' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.RelatesTo = new List<Composition.RelatesToComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Composition.RelatesToComponent v_RelatesTo = new Hl7.Fhir.Model.Composition.RelatesToComponent();
            v_RelatesTo.DeserializeJson(ref reader, options);
            current.RelatesTo.Add(v_RelatesTo);

            if (!reader.Read())
            {
              throw new JsonException($"Composition error reading 'relatesTo' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.RelatesTo.Count == 0)
          {
            current.RelatesTo = null;
          }
          break;

        case "event":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Composition error reading 'event' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Event = new List<Composition.EventComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Composition.EventComponent v_Event = new Hl7.Fhir.Model.Composition.EventComponent();
            v_Event.DeserializeJson(ref reader, options);
            current.Event.Add(v_Event);

            if (!reader.Read())
            {
              throw new JsonException($"Composition error reading 'event' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Event.Count == 0)
          {
            current.Event = null;
          }
          break;

        case "section":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Composition error reading 'section' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Section = new List<Composition.SectionComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Composition.SectionComponent v_Section = new Hl7.Fhir.Model.Composition.SectionComponent();
            v_Section.DeserializeJson(ref reader, options);
            current.Section.Add(v_Section);

            if (!reader.Read())
            {
              throw new JsonException($"Composition error reading 'section' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Section.Count == 0)
          {
            current.Section = null;
          }
          break;

        // Complex: Composition, Export: Composition, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#Attester into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Composition.AttesterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#Attester, Export: AttesterComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("mode",current.ModeElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("time",current.TimeElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("party", current.Party, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Attester
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Composition.AttesterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Composition.AttesterComponent >>> Composition#Attester.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Composition.AttesterComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Attester
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Composition.AttesterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "mode":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ModeElement = new Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>();
            reader.Skip();
          }
          else
          {
            current.ModeElement = new Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Composition.CompositionAttestationMode>(reader.GetString()));
          }
          break;

        case "_mode":
          if (current.ModeElement == null) { current.ModeElement = new Code<Hl7.Fhir.Model.Composition.CompositionAttestationMode>(); }
          ((Hl7.Fhir.Model.Element)current.ModeElement).DeserializeJson(ref reader, options);
          break;

        case "time":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TimeElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.TimeElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_time":
          if (current.TimeElement == null) { current.TimeElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.TimeElement).DeserializeJson(ref reader, options);
          break;

        case "party":
          current.Party = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Party).DeserializeJson(ref reader, options);
          break;

        // Complex: attester, Export: AttesterComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#RelatesTo into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Composition.RelatesToComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#RelatesTo, Export: RelatesToComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("code",current.CodeElement,writer,options);

      if (current.Target != null)
      {
        switch (current.Target)
        {
          case Hl7.Fhir.Model.Identifier v_Identifier:
            JsonStreamUtilities.SerializeComplexProperty("targetIdentifier", v_Identifier, writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            JsonStreamUtilities.SerializeComplexProperty("targetReference", v_ResourceReference, writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#RelatesTo
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Composition.RelatesToComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Composition.RelatesToComponent >>> Composition#RelatesTo.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Composition.RelatesToComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#RelatesTo
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Composition.RelatesToComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CodeElement = new Code<Hl7.Fhir.Model.DocumentRelationshipType>();
            reader.Skip();
          }
          else
          {
            current.CodeElement = new Code<Hl7.Fhir.Model.DocumentRelationshipType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DocumentRelationshipType>(reader.GetString()));
          }
          break;

        case "_code":
          if (current.CodeElement == null) { current.CodeElement = new Code<Hl7.Fhir.Model.DocumentRelationshipType>(); }
          ((Hl7.Fhir.Model.Element)current.CodeElement).DeserializeJson(ref reader, options);
          break;

        case "targetIdentifier":
          current.Target = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.Target).DeserializeJson(ref reader, options);
          break;

        case "targetReference":
          current.Target = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Target).DeserializeJson(ref reader, options);
          break;

        // Complex: relatesTo, Export: RelatesToComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#Event into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Composition.EventComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#Event, Export: EventComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("code", current.Code, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("period", current.Period, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("detail", current.Detail, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Event
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Composition.EventComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Composition.EventComponent >>> Composition#Event.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Composition.EventComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Event
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Composition.EventComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EventComponent error reading 'code' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Code = new Hl7.Fhir.Model.CodeableConcept();
            v_Code.DeserializeJson(ref reader, options);
            current.Code.Add(v_Code);

            if (!reader.Read())
            {
              throw new JsonException($"EventComponent error reading 'code' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Code.Count == 0)
          {
            current.Code = null;
          }
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        case "detail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"EventComponent error reading 'detail' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Detail = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Detail = new Hl7.Fhir.Model.ResourceReference();
            v_Detail.DeserializeJson(ref reader, options);
            current.Detail.Add(v_Detail);

            if (!reader.Read())
            {
              throw new JsonException($"EventComponent error reading 'detail' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Detail.Count == 0)
          {
            current.Detail = null;
          }
          break;

        // Complex: event, Export: EventComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Composition#Section into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Composition.SectionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Composition#Section, Export: SectionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("title",current.TitleElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("code", current.Code, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("author", current.Author, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("focus", current.Focus, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("text", current.Text, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("mode",current.ModeElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("orderedBy", current.OrderedBy, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("entry", current.Entry, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("emptyReason", current.EmptyReason, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("section", current.Section, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Section
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Composition.SectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Composition.SectionComponent >>> Composition#Section.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Composition.SectionComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Composition#Section
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Composition.SectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "title":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TitleElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.TitleElement = new FhirString(reader.GetString());
          }
          break;

        case "_title":
          if (current.TitleElement == null) { current.TitleElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.TitleElement).DeserializeJson(ref reader, options);
          break;

        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Code).DeserializeJson(ref reader, options);
          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SectionComponent error reading 'author' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Author = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Author = new Hl7.Fhir.Model.ResourceReference();
            v_Author.DeserializeJson(ref reader, options);
            current.Author.Add(v_Author);

            if (!reader.Read())
            {
              throw new JsonException($"SectionComponent error reading 'author' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Author.Count == 0)
          {
            current.Author = null;
          }
          break;

        case "focus":
          current.Focus = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Focus).DeserializeJson(ref reader, options);
          break;

        case "text":
          current.Text = new Hl7.Fhir.Model.Narrative();
          ((Hl7.Fhir.Model.Narrative)current.Text).DeserializeJson(ref reader, options);
          break;

        case "mode":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ModeElement = new Code<Hl7.Fhir.Model.ListMode>();
            reader.Skip();
          }
          else
          {
            current.ModeElement = new Code<Hl7.Fhir.Model.ListMode>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ListMode>(reader.GetString()));
          }
          break;

        case "_mode":
          if (current.ModeElement == null) { current.ModeElement = new Code<Hl7.Fhir.Model.ListMode>(); }
          ((Hl7.Fhir.Model.Element)current.ModeElement).DeserializeJson(ref reader, options);
          break;

        case "orderedBy":
          current.OrderedBy = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.OrderedBy).DeserializeJson(ref reader, options);
          break;

        case "entry":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SectionComponent error reading 'entry' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Entry = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Entry = new Hl7.Fhir.Model.ResourceReference();
            v_Entry.DeserializeJson(ref reader, options);
            current.Entry.Add(v_Entry);

            if (!reader.Read())
            {
              throw new JsonException($"SectionComponent error reading 'entry' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Entry.Count == 0)
          {
            current.Entry = null;
          }
          break;

        case "emptyReason":
          current.EmptyReason = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.EmptyReason).DeserializeJson(ref reader, options);
          break;

        case "section":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SectionComponent error reading 'section' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Section = new List<Composition.SectionComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Composition.SectionComponent v_Section = new Hl7.Fhir.Model.Composition.SectionComponent();
            v_Section.DeserializeJson(ref reader, options);
            current.Section.Add(v_Section);

            if (!reader.Read())
            {
              throw new JsonException($"SectionComponent error reading 'section' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Section.Count == 0)
          {
            current.Section = null;
          }
          break;

        // Complex: section, Export: SectionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class CompositionJsonConverter : JsonConverter<Hl7.Fhir.Model.Composition>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Composition value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Composition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Composition();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
