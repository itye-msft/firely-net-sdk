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
  /// JSON Serialization Extensions for Specimen
  /// </summary>
  public static class SpecimenSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Specimen into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Specimen current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Specimen");
      // Complex: Specimen, Export: Specimen, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("accessionIdentifier", current.AccessionIdentifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("subject", current.Subject, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("receivedTime",current.ReceivedTimeElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("parent", current.Parent, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("request", current.Request, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("collection", current.Collection, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("processing", current.Processing, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("container", current.Container, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("condition", current.Condition, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("note", current.Note, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Specimen current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Specimen >>> Specimen.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Specimen: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Specimen current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Specimen error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"Specimen error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "accessionIdentifier":
          current.AccessionIdentifier = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.AccessionIdentifier).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Specimen.SpecimenStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Specimen.SpecimenStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Specimen.SpecimenStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.Specimen.SpecimenStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Subject).DeserializeJson(ref reader, options);
          break;

        case "receivedTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ReceivedTimeElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.ReceivedTimeElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_receivedTime":
          if (current.ReceivedTimeElement == null) { current.ReceivedTimeElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.ReceivedTimeElement).DeserializeJson(ref reader, options);
          break;

        case "parent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Specimen error reading 'parent' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Parent = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Parent = new Hl7.Fhir.Model.ResourceReference();
            v_Parent.DeserializeJson(ref reader, options);
            current.Parent.Add(v_Parent);

            if (!reader.Read())
            {
              throw new JsonException($"Specimen error reading 'parent' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Parent.Count == 0)
          {
            current.Parent = null;
          }
          break;

        case "request":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Specimen error reading 'request' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Request = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Request = new Hl7.Fhir.Model.ResourceReference();
            v_Request.DeserializeJson(ref reader, options);
            current.Request.Add(v_Request);

            if (!reader.Read())
            {
              throw new JsonException($"Specimen error reading 'request' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Request.Count == 0)
          {
            current.Request = null;
          }
          break;

        case "collection":
          current.Collection = new Hl7.Fhir.Model.Specimen.CollectionComponent();
          ((Hl7.Fhir.Model.Specimen.CollectionComponent)current.Collection).DeserializeJson(ref reader, options);
          break;

        case "processing":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Specimen error reading 'processing' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Processing = new List<Specimen.ProcessingComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Specimen.ProcessingComponent v_Processing = new Hl7.Fhir.Model.Specimen.ProcessingComponent();
            v_Processing.DeserializeJson(ref reader, options);
            current.Processing.Add(v_Processing);

            if (!reader.Read())
            {
              throw new JsonException($"Specimen error reading 'processing' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Processing.Count == 0)
          {
            current.Processing = null;
          }
          break;

        case "container":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Specimen error reading 'container' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Container = new List<Specimen.ContainerComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Specimen.ContainerComponent v_Container = new Hl7.Fhir.Model.Specimen.ContainerComponent();
            v_Container.DeserializeJson(ref reader, options);
            current.Container.Add(v_Container);

            if (!reader.Read())
            {
              throw new JsonException($"Specimen error reading 'container' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Container.Count == 0)
          {
            current.Container = null;
          }
          break;

        case "condition":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Specimen error reading 'condition' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Condition = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Condition = new Hl7.Fhir.Model.CodeableConcept();
            v_Condition.DeserializeJson(ref reader, options);
            current.Condition.Add(v_Condition);

            if (!reader.Read())
            {
              throw new JsonException($"Specimen error reading 'condition' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Condition.Count == 0)
          {
            current.Condition = null;
          }
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Specimen error reading 'note' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Annotation v_Note = new Hl7.Fhir.Model.Annotation();
            v_Note.DeserializeJson(ref reader, options);
            current.Note.Add(v_Note);

            if (!reader.Read())
            {
              throw new JsonException($"Specimen error reading 'note' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }
          break;

        // Complex: Specimen, Export: Specimen, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Specimen#Collection into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Specimen.CollectionComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Specimen#Collection, Export: CollectionComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("collector", current.Collector, writer, options);

      if (current.Collected != null)
      {
        switch (current.Collected)
        {
          case Hl7.Fhir.Model.FhirDateTime v_FhirDateTime:
            JsonStreamUtilities.SerializePrimitiveProperty("collectedDateTime",v_FhirDateTime,writer,options);
            break;
          case Hl7.Fhir.Model.Period v_Period:
            writer.WritePropertyName("collectedPeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      JsonStreamUtilities.SerializeComplexProperty("duration", current.Duration, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("quantity", current.Quantity, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("method", current.Method, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("bodySite", current.BodySite, writer, options);

      if (current.FastingStatus != null)
      {
        switch (current.FastingStatus)
        {
          case Hl7.Fhir.Model.CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("fastingStatusCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.Duration v_Duration:
            writer.WritePropertyName("fastingStatusDuration");
            v_Duration.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen#Collection
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Specimen.CollectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Specimen.CollectionComponent >>> Specimen#Collection.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Specimen.CollectionComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen#Collection
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Specimen.CollectionComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "collector":
          current.Collector = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Collector).DeserializeJson(ref reader, options);
          break;

        case "collectedDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Collected = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Collected = new FhirDateTime(reader.GetString());
          }
          break;

        case "_collectedDateTime":
          if (current.Collected == null) { current.Collected = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Collected).DeserializeJson(ref reader, options);
          break;

        case "collectedPeriod":
          current.Collected = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Collected).DeserializeJson(ref reader, options);
          break;

        case "duration":
          current.Duration = new Hl7.Fhir.Model.Duration();
          ((Hl7.Fhir.Model.Duration)current.Duration).DeserializeJson(ref reader, options);
          break;

        case "quantity":
          current.Quantity = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Quantity).DeserializeJson(ref reader, options);
          break;

        case "method":
          current.Method = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Method).DeserializeJson(ref reader, options);
          break;

        case "bodySite":
          current.BodySite = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.BodySite).DeserializeJson(ref reader, options);
          break;

        case "fastingStatusCodeableConcept":
          current.FastingStatus = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.FastingStatus).DeserializeJson(ref reader, options);
          break;

        case "fastingStatusDuration":
          current.FastingStatus = new Hl7.Fhir.Model.Duration();
          ((Hl7.Fhir.Model.Duration)current.FastingStatus).DeserializeJson(ref reader, options);
          break;

        // Complex: collection, Export: CollectionComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Specimen#Processing into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Specimen.ProcessingComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Specimen#Processing, Export: ProcessingComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("description",current.DescriptionElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("procedure", current.Procedure, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("additive", current.Additive, writer, options);

      if (current.Time != null)
      {
        switch (current.Time)
        {
          case Hl7.Fhir.Model.FhirDateTime v_FhirDateTime:
            JsonStreamUtilities.SerializePrimitiveProperty("timeDateTime",v_FhirDateTime,writer,options);
            break;
          case Hl7.Fhir.Model.Period v_Period:
            writer.WritePropertyName("timePeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen#Processing
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Specimen.ProcessingComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Specimen.ProcessingComponent >>> Specimen#Processing.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Specimen.ProcessingComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen#Processing
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Specimen.ProcessingComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "procedure":
          current.Procedure = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Procedure).DeserializeJson(ref reader, options);
          break;

        case "additive":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ProcessingComponent error reading 'additive' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Additive = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Additive = new Hl7.Fhir.Model.ResourceReference();
            v_Additive.DeserializeJson(ref reader, options);
            current.Additive.Add(v_Additive);

            if (!reader.Read())
            {
              throw new JsonException($"ProcessingComponent error reading 'additive' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Additive.Count == 0)
          {
            current.Additive = null;
          }
          break;

        case "timeDateTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Time = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.Time = new FhirDateTime(reader.GetString());
          }
          break;

        case "_timeDateTime":
          if (current.Time == null) { current.Time = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.Time).DeserializeJson(ref reader, options);
          break;

        case "timePeriod":
          current.Time = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Time).DeserializeJson(ref reader, options);
          break;

        // Complex: processing, Export: ProcessingComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Specimen#Container into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Specimen.ContainerComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Specimen#Container, Export: ContainerComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("description",current.DescriptionElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("capacity", current.Capacity, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("specimenQuantity", current.SpecimenQuantity, writer, options);

      if (current.Additive != null)
      {
        switch (current.Additive)
        {
          case Hl7.Fhir.Model.CodeableConcept v_CodeableConcept:
            writer.WritePropertyName("additiveCodeableConcept");
            v_CodeableConcept.SerializeJson(writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            writer.WritePropertyName("additiveReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
        }
      }
      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen#Container
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Specimen.ContainerComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Specimen.ContainerComponent >>> Specimen#Container.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Specimen.ContainerComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Specimen#Container
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Specimen.ContainerComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ContainerComponent error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"ContainerComponent error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "capacity":
          current.Capacity = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Capacity).DeserializeJson(ref reader, options);
          break;

        case "specimenQuantity":
          current.SpecimenQuantity = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.SpecimenQuantity).DeserializeJson(ref reader, options);
          break;

        case "additiveCodeableConcept":
          current.Additive = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Additive).DeserializeJson(ref reader, options);
          break;

        case "additiveReference":
          current.Additive = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Additive).DeserializeJson(ref reader, options);
          break;

        // Complex: container, Export: ContainerComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SpecimenJsonConverter : JsonConverter<Hl7.Fhir.Model.Specimen>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Specimen value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Specimen Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Specimen();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
