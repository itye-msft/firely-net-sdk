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
  /// JSON Serialization Extensions for SubstanceReferenceInformation
  /// </summary>
  public static class SubstanceReferenceInformationSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR SubstanceReferenceInformation into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","SubstanceReferenceInformation");
      // Complex: SubstanceReferenceInformation, Export: SubstanceReferenceInformation, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("comment",current.CommentElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("gene", current.Gene, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("geneElement", current.GeneElement, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("classification", current.Classification, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("target", current.Target, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"SubstanceReferenceInformation >>> SubstanceReferenceInformation.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"SubstanceReferenceInformation: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.SubstanceReferenceInformation current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "comment":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CommentElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.CommentElement = new FhirString(reader.GetString());
          }
          break;

        case "_comment":
          if (current.CommentElement == null) { current.CommentElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.CommentElement).DeserializeJson(ref reader, options);
          break;

        case "gene":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SubstanceReferenceInformation error reading 'gene' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Gene = new List<SubstanceReferenceInformation.GeneComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent v_Gene = new Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent();
            v_Gene.DeserializeJson(ref reader, options);
            current.Gene.Add(v_Gene);

            if (!reader.Read())
            {
              throw new JsonException($"SubstanceReferenceInformation error reading 'gene' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Gene.Count == 0)
          {
            current.Gene = null;
          }
          break;

        case "geneElement":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SubstanceReferenceInformation error reading 'geneElement' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.GeneElement = new List<SubstanceReferenceInformation.GeneElementComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent v_GeneElement = new Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent();
            v_GeneElement.DeserializeJson(ref reader, options);
            current.GeneElement.Add(v_GeneElement);

            if (!reader.Read())
            {
              throw new JsonException($"SubstanceReferenceInformation error reading 'geneElement' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.GeneElement.Count == 0)
          {
            current.GeneElement = null;
          }
          break;

        case "classification":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SubstanceReferenceInformation error reading 'classification' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Classification = new List<SubstanceReferenceInformation.ClassificationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent v_Classification = new Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent();
            v_Classification.DeserializeJson(ref reader, options);
            current.Classification.Add(v_Classification);

            if (!reader.Read())
            {
              throw new JsonException($"SubstanceReferenceInformation error reading 'classification' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Classification.Count == 0)
          {
            current.Classification = null;
          }
          break;

        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"SubstanceReferenceInformation error reading 'target' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Target = new List<SubstanceReferenceInformation.TargetComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent v_Target = new Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent();
            v_Target.DeserializeJson(ref reader, options);
            current.Target.Add(v_Target);

            if (!reader.Read())
            {
              throw new JsonException($"SubstanceReferenceInformation error reading 'target' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Target.Count == 0)
          {
            current.Target = null;
          }
          break;

        // Complex: SubstanceReferenceInformation, Export: SubstanceReferenceInformation, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstanceReferenceInformation#Gene into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstanceReferenceInformation#Gene, Export: GeneComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("geneSequenceOrigin", current.GeneSequenceOrigin, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("gene", current.Gene, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("source", current.Source, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#Gene
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"SubstanceReferenceInformation.GeneComponent >>> SubstanceReferenceInformation#Gene.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"SubstanceReferenceInformation.GeneComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#Gene
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.SubstanceReferenceInformation.GeneComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "geneSequenceOrigin":
          current.GeneSequenceOrigin = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.GeneSequenceOrigin).DeserializeJson(ref reader, options);
          break;

        case "gene":
          current.Gene = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Gene).DeserializeJson(ref reader, options);
          break;

        case "source":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GeneComponent error reading 'source' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Source = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Source = new Hl7.Fhir.Model.ResourceReference();
            v_Source.DeserializeJson(ref reader, options);
            current.Source.Add(v_Source);

            if (!reader.Read())
            {
              throw new JsonException($"GeneComponent error reading 'source' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Source.Count == 0)
          {
            current.Source = null;
          }
          break;

        // Complex: gene, Export: GeneComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstanceReferenceInformation#GeneElement into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstanceReferenceInformation#GeneElement, Export: GeneElementComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("element", current.Element, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("source", current.Source, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#GeneElement
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"SubstanceReferenceInformation.GeneElementComponent >>> SubstanceReferenceInformation#GeneElement.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"SubstanceReferenceInformation.GeneElementComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#GeneElement
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.SubstanceReferenceInformation.GeneElementComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "element":
          current.Element = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.Element).DeserializeJson(ref reader, options);
          break;

        case "source":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"GeneElementComponent error reading 'source' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Source = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Source = new Hl7.Fhir.Model.ResourceReference();
            v_Source.DeserializeJson(ref reader, options);
            current.Source.Add(v_Source);

            if (!reader.Read())
            {
              throw new JsonException($"GeneElementComponent error reading 'source' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Source.Count == 0)
          {
            current.Source = null;
          }
          break;

        // Complex: geneElement, Export: GeneElementComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstanceReferenceInformation#Classification into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstanceReferenceInformation#Classification, Export: ClassificationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("domain", current.Domain, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("classification", current.Classification, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("subtype", current.Subtype, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("source", current.Source, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#Classification
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"SubstanceReferenceInformation.ClassificationComponent >>> SubstanceReferenceInformation#Classification.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"SubstanceReferenceInformation.ClassificationComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#Classification
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.SubstanceReferenceInformation.ClassificationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "domain":
          current.Domain = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Domain).DeserializeJson(ref reader, options);
          break;

        case "classification":
          current.Classification = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Classification).DeserializeJson(ref reader, options);
          break;

        case "subtype":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ClassificationComponent error reading 'subtype' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Subtype = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Subtype = new Hl7.Fhir.Model.CodeableConcept();
            v_Subtype.DeserializeJson(ref reader, options);
            current.Subtype.Add(v_Subtype);

            if (!reader.Read())
            {
              throw new JsonException($"ClassificationComponent error reading 'subtype' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Subtype.Count == 0)
          {
            current.Subtype = null;
          }
          break;

        case "source":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ClassificationComponent error reading 'source' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Source = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Source = new Hl7.Fhir.Model.ResourceReference();
            v_Source.DeserializeJson(ref reader, options);
            current.Source.Add(v_Source);

            if (!reader.Read())
            {
              throw new JsonException($"ClassificationComponent error reading 'source' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Source.Count == 0)
          {
            current.Source = null;
          }
          break;

        // Complex: classification, Export: ClassificationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR SubstanceReferenceInformation#Target into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: SubstanceReferenceInformation#Target, Export: TargetComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("target", current.Target, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("interaction", current.Interaction, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("organism", current.Organism, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("organismType", current.OrganismType, writer, options);

      if (current.Amount != null)
      {
        switch (current.Amount)
        {
          case Hl7.Fhir.Model.Quantity v_Quantity:
            JsonStreamUtilities.SerializeComplexProperty("amountQuantity", v_Quantity, writer, options);
            break;
          case Hl7.Fhir.Model.Range v_Range:
            JsonStreamUtilities.SerializeComplexProperty("amountRange", v_Range, writer, options);
            break;
          case Hl7.Fhir.Model.FhirString v_FhirString:
            JsonStreamUtilities.SerializePrimitiveProperty("amountString",v_FhirString,writer,options);
            break;
        }
      }
      JsonStreamUtilities.SerializeComplexProperty("amountType", current.AmountType, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("source", current.Source, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#Target
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"SubstanceReferenceInformation.TargetComponent >>> SubstanceReferenceInformation#Target.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"SubstanceReferenceInformation.TargetComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR SubstanceReferenceInformation#Target
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.SubstanceReferenceInformation.TargetComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "target":
          current.Target = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.Target).DeserializeJson(ref reader, options);
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "interaction":
          current.Interaction = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Interaction).DeserializeJson(ref reader, options);
          break;

        case "organism":
          current.Organism = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Organism).DeserializeJson(ref reader, options);
          break;

        case "organismType":
          current.OrganismType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.OrganismType).DeserializeJson(ref reader, options);
          break;

        case "amountQuantity":
          current.Amount = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Amount).DeserializeJson(ref reader, options);
          break;

        case "amountRange":
          current.Amount = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.Amount).DeserializeJson(ref reader, options);
          break;

        case "amountString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Amount = new FhirString();
            reader.Skip();
          }
          else
          {
            current.Amount = new FhirString(reader.GetString());
          }
          break;

        case "_amountString":
          if (current.Amount == null) { current.Amount = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.Amount).DeserializeJson(ref reader, options);
          break;

        case "amountType":
          current.AmountType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.AmountType).DeserializeJson(ref reader, options);
          break;

        case "source":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"TargetComponent error reading 'source' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Source = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Source = new Hl7.Fhir.Model.ResourceReference();
            v_Source.DeserializeJson(ref reader, options);
            current.Source.Add(v_Source);

            if (!reader.Read())
            {
              throw new JsonException($"TargetComponent error reading 'source' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Source.Count == 0)
          {
            current.Source = null;
          }
          break;

        // Complex: target, Export: TargetComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SubstanceReferenceInformationJsonConverter : JsonConverter<Hl7.Fhir.Model.SubstanceReferenceInformation>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.SubstanceReferenceInformation value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.SubstanceReferenceInformation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.SubstanceReferenceInformation();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
