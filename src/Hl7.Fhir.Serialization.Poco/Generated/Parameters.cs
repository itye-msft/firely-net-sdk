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
  /// JSON Serialization Extensions for Parameters
  /// </summary>
  public static class ParametersSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Parameters into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Parameters current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Parameters");
      // Complex: Parameters, Export: Parameters, Base: Resource (Resource)
      ((Hl7.Fhir.Model.Resource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("parameter", current.Parameter, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Parameters
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Parameters current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Parameters >>> Parameters.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Parameters: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Parameters
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Parameters current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "parameter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Parameters error reading 'parameter' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Parameter = new List<Parameters.ParameterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Parameters.ParameterComponent v_Parameter = new Hl7.Fhir.Model.Parameters.ParameterComponent();
            v_Parameter.DeserializeJson(ref reader, options);
            current.Parameter.Add(v_Parameter);

            if (!reader.Read())
            {
              throw new JsonException($"Parameters error reading 'parameter' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Parameter.Count == 0)
          {
            current.Parameter = null;
          }
          break;

        // Complex: Parameters, Export: Parameters, Base: Resource
        default:
          ((Hl7.Fhir.Model.Resource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Parameters#Parameter into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Parameters.ParameterComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Parameters#Parameter, Export: ParameterComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("name",current.NameElement,writer,options);

      if (current.Value != null)
      {
        switch (current.Value)
        {
          case Hl7.Fhir.Model.Base64Binary v_Base64Binary:
            JsonStreamUtilities.SerializePrimitiveProperty("valueBase64Binary",v_Base64Binary,writer,options);
            break;
          case Hl7.Fhir.Model.FhirBoolean v_FhirBoolean:
            JsonStreamUtilities.SerializePrimitiveProperty("valueBoolean",v_FhirBoolean,writer,options);
            break;
          case Hl7.Fhir.Model.Canonical v_Canonical:
            JsonStreamUtilities.SerializePrimitiveProperty("valueCanonical",v_Canonical,writer,options);
            break;
          case Hl7.Fhir.Model.Code v_Code:
            JsonStreamUtilities.SerializePrimitiveProperty("valueCode",v_Code,writer,options);
            break;
          case Hl7.Fhir.Model.Date v_Date:
            JsonStreamUtilities.SerializePrimitiveProperty("valueDate",v_Date,writer,options);
            break;
          case Hl7.Fhir.Model.FhirDateTime v_FhirDateTime:
            JsonStreamUtilities.SerializePrimitiveProperty("valueDateTime",v_FhirDateTime,writer,options);
            break;
          case Hl7.Fhir.Model.FhirDecimal v_FhirDecimal:
            JsonStreamUtilities.SerializePrimitiveProperty("valueDecimal",v_FhirDecimal,writer,options);
            break;
          case Hl7.Fhir.Model.Id v_Id:
            JsonStreamUtilities.SerializePrimitiveProperty("valueId",v_Id,writer,options);
            break;
          case Hl7.Fhir.Model.Instant v_Instant:
            JsonStreamUtilities.SerializePrimitiveProperty("valueInstant",v_Instant,writer,options);
            break;
          case Hl7.Fhir.Model.Integer v_Integer:
            JsonStreamUtilities.SerializePrimitiveProperty("valueInteger",v_Integer,writer,options);
            break;
          case Hl7.Fhir.Model.Markdown v_Markdown:
            JsonStreamUtilities.SerializePrimitiveProperty("valueMarkdown",v_Markdown,writer,options);
            break;
          case Hl7.Fhir.Model.Oid v_Oid:
            JsonStreamUtilities.SerializePrimitiveProperty("valueOid",v_Oid,writer,options);
            break;
          case Hl7.Fhir.Model.PositiveInt v_PositiveInt:
            JsonStreamUtilities.SerializePrimitiveProperty("valuePositiveInt",v_PositiveInt,writer,options);
            break;
          case Hl7.Fhir.Model.FhirString v_FhirString:
            JsonStreamUtilities.SerializePrimitiveProperty("valueString",v_FhirString,writer,options);
            break;
          case Hl7.Fhir.Model.Time v_Time:
            JsonStreamUtilities.SerializePrimitiveProperty("valueTime",v_Time,writer,options);
            break;
          case Hl7.Fhir.Model.UnsignedInt v_UnsignedInt:
            JsonStreamUtilities.SerializePrimitiveProperty("valueUnsignedInt",v_UnsignedInt,writer,options);
            break;
          case Hl7.Fhir.Model.FhirUri v_FhirUri:
            JsonStreamUtilities.SerializePrimitiveProperty("valueUri",v_FhirUri,writer,options);
            break;
          case Hl7.Fhir.Model.FhirUrl v_FhirUrl:
            JsonStreamUtilities.SerializePrimitiveProperty("valueUrl",v_FhirUrl,writer,options);
            break;
          case Hl7.Fhir.Model.Uuid v_Uuid:
            JsonStreamUtilities.SerializePrimitiveProperty("valueUuid",v_Uuid,writer,options);
            break;
          case Hl7.Fhir.Model.Address v_Address:
            JsonStreamUtilities.SerializeComplexProperty("valueAddress", v_Address, writer, options);
            break;
          case Hl7.Fhir.Model.Age v_Age:
            JsonStreamUtilities.SerializeComplexProperty("valueAge", v_Age, writer, options);
            break;
          case Hl7.Fhir.Model.Annotation v_Annotation:
            JsonStreamUtilities.SerializeComplexProperty("valueAnnotation", v_Annotation, writer, options);
            break;
          case Hl7.Fhir.Model.Attachment v_Attachment:
            JsonStreamUtilities.SerializeComplexProperty("valueAttachment", v_Attachment, writer, options);
            break;
          case Hl7.Fhir.Model.CodeableConcept v_CodeableConcept:
            JsonStreamUtilities.SerializeComplexProperty("valueCodeableConcept", v_CodeableConcept, writer, options);
            break;
          case Hl7.Fhir.Model.Coding v_Coding:
            JsonStreamUtilities.SerializeComplexProperty("valueCoding", v_Coding, writer, options);
            break;
          case Hl7.Fhir.Model.ContactPoint v_ContactPoint:
            JsonStreamUtilities.SerializeComplexProperty("valueContactPoint", v_ContactPoint, writer, options);
            break;
          case Hl7.Fhir.Model.Count v_Count:
            JsonStreamUtilities.SerializeComplexProperty("valueCount", v_Count, writer, options);
            break;
          case Hl7.Fhir.Model.Distance v_Distance:
            JsonStreamUtilities.SerializeComplexProperty("valueDistance", v_Distance, writer, options);
            break;
          case Hl7.Fhir.Model.Duration v_Duration:
            JsonStreamUtilities.SerializeComplexProperty("valueDuration", v_Duration, writer, options);
            break;
          case Hl7.Fhir.Model.HumanName v_HumanName:
            JsonStreamUtilities.SerializeComplexProperty("valueHumanName", v_HumanName, writer, options);
            break;
          case Hl7.Fhir.Model.Identifier v_Identifier:
            JsonStreamUtilities.SerializeComplexProperty("valueIdentifier", v_Identifier, writer, options);
            break;
          case Hl7.Fhir.Model.Money v_Money:
            JsonStreamUtilities.SerializeComplexProperty("valueMoney", v_Money, writer, options);
            break;
          case Hl7.Fhir.Model.Period v_Period:
            JsonStreamUtilities.SerializeComplexProperty("valuePeriod", v_Period, writer, options);
            break;
          case Hl7.Fhir.Model.Quantity v_Quantity:
            JsonStreamUtilities.SerializeComplexProperty("valueQuantity", v_Quantity, writer, options);
            break;
          case Hl7.Fhir.Model.Range v_Range:
            JsonStreamUtilities.SerializeComplexProperty("valueRange", v_Range, writer, options);
            break;
          case Hl7.Fhir.Model.Ratio v_Ratio:
            JsonStreamUtilities.SerializeComplexProperty("valueRatio", v_Ratio, writer, options);
            break;
          case Hl7.Fhir.Model.ResourceReference v_ResourceReference:
            JsonStreamUtilities.SerializeComplexProperty("valueReference", v_ResourceReference, writer, options);
            break;
          case Hl7.Fhir.Model.SampledData v_SampledData:
            JsonStreamUtilities.SerializeComplexProperty("valueSampledData", v_SampledData, writer, options);
            break;
          case Hl7.Fhir.Model.Signature v_Signature:
            JsonStreamUtilities.SerializeComplexProperty("valueSignature", v_Signature, writer, options);
            break;
          case Hl7.Fhir.Model.Timing v_Timing:
            JsonStreamUtilities.SerializeComplexProperty("valueTiming", v_Timing, writer, options);
            break;
          case Hl7.Fhir.Model.ContactDetail v_ContactDetail:
            JsonStreamUtilities.SerializeComplexProperty("valueContactDetail", v_ContactDetail, writer, options);
            break;
          case Hl7.Fhir.Model.Contributor v_Contributor:
            JsonStreamUtilities.SerializeComplexProperty("valueContributor", v_Contributor, writer, options);
            break;
          case Hl7.Fhir.Model.DataRequirement v_DataRequirement:
            JsonStreamUtilities.SerializeComplexProperty("valueDataRequirement", v_DataRequirement, writer, options);
            break;
          case Hl7.Fhir.Model.Expression v_Expression:
            JsonStreamUtilities.SerializeComplexProperty("valueExpression", v_Expression, writer, options);
            break;
          case Hl7.Fhir.Model.ParameterDefinition v_ParameterDefinition:
            JsonStreamUtilities.SerializeComplexProperty("valueParameterDefinition", v_ParameterDefinition, writer, options);
            break;
          case Hl7.Fhir.Model.RelatedArtifact v_RelatedArtifact:
            JsonStreamUtilities.SerializeComplexProperty("valueRelatedArtifact", v_RelatedArtifact, writer, options);
            break;
          case Hl7.Fhir.Model.TriggerDefinition v_TriggerDefinition:
            JsonStreamUtilities.SerializeComplexProperty("valueTriggerDefinition", v_TriggerDefinition, writer, options);
            break;
          case Hl7.Fhir.Model.UsageContext v_UsageContext:
            JsonStreamUtilities.SerializeComplexProperty("valueUsageContext", v_UsageContext, writer, options);
            break;
          case Hl7.Fhir.Model.Dosage v_Dosage:
            JsonStreamUtilities.SerializeComplexProperty("valueDosage", v_Dosage, writer, options);
            break;
          case Hl7.Fhir.Model.Meta v_Meta:
            JsonStreamUtilities.SerializeComplexProperty("valueMeta", v_Meta, writer, options);
            break;
        }
      }
      JsonStreamUtilities.SerializeComplexProperty("resource", current.Resource, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("part", current.Part, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Parameters#Parameter
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Parameters.ParameterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Parameters.ParameterComponent >>> Parameters#Parameter.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Parameters.ParameterComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Parameters#Parameter
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Parameters.ParameterComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "name":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.NameElement = new FhirString(reader.GetString());
          }
          break;

        case "_name":
          if (current.NameElement == null) { current.NameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.NameElement).DeserializeJson(ref reader, options);
          break;

        case "valueBase64Binary":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Base64Binary();
            reader.Skip();
          }
          else
          {
            current.Value = new Base64Binary(System.Convert.FromBase64String(reader.GetString()));
          }
          break;

        case "_valueBase64Binary":
          if (current.Value == null) { current.Value = new Base64Binary(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueBoolean":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.Value = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_valueBoolean":
          if (current.Value == null) { current.Value = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueCanonical":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Canonical();
            reader.Skip();
          }
          else
          {
            current.Value = new Canonical(reader.GetString());
          }
          break;

        case "_valueCanonical":
          if (current.Value == null) { current.Value = new Canonical(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueCode":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Code();
            reader.Skip();
          }
          else
          {
            current.Value = new Code(reader.GetString());
          }
          break;

        case "_valueCode":
          if (current.Value == null) { current.Value = new Code(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Date();
            reader.Skip();
          }
          else
          {
            current.Value = new Date(reader.GetString());
          }
          break;

        case "_valueDate":
          if (current.Value == null) { current.Value = new Date(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
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

        case "valueDecimal":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.Value = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_valueDecimal":
          if (current.Value == null) { current.Value = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueId":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Id();
            reader.Skip();
          }
          else
          {
            current.Value = new Id(reader.GetString());
          }
          break;

        case "_valueId":
          if (current.Value == null) { current.Value = new Id(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueInstant":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Instant();
            reader.Skip();
          }
          else
          {
            current.Value = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_valueInstant":
          if (current.Value == null) { current.Value = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueInteger":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Integer();
            reader.Skip();
          }
          else
          {
            current.Value = new Integer(reader.GetInt32());
          }
          break;

        case "_valueInteger":
          if (current.Value == null) { current.Value = new Integer(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueMarkdown":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Markdown();
            reader.Skip();
          }
          else
          {
            current.Value = new Markdown(reader.GetString());
          }
          break;

        case "_valueMarkdown":
          if (current.Value == null) { current.Value = new Markdown(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueOid":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Oid();
            reader.Skip();
          }
          else
          {
            current.Value = new Oid(reader.GetString());
          }
          break;

        case "_valueOid":
          if (current.Value == null) { current.Value = new Oid(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valuePositiveInt":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new PositiveInt();
            reader.Skip();
          }
          else
          {
            current.Value = new PositiveInt(reader.GetInt32());
          }
          break;

        case "_valuePositiveInt":
          if (current.Value == null) { current.Value = new PositiveInt(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new FhirString();
            reader.Skip();
          }
          else
          {
            current.Value = new FhirString(reader.GetString());
          }
          break;

        case "_valueString":
          if (current.Value == null) { current.Value = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueTime":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Time();
            reader.Skip();
          }
          else
          {
            current.Value = new Time(reader.GetString());
          }
          break;

        case "_valueTime":
          if (current.Value == null) { current.Value = new Time(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueUnsignedInt":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new UnsignedInt();
            reader.Skip();
          }
          else
          {
            current.Value = new UnsignedInt(reader.GetInt32());
          }
          break;

        case "_valueUnsignedInt":
          if (current.Value == null) { current.Value = new UnsignedInt(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueUri":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new FhirUri();
            reader.Skip();
          }
          else
          {
            current.Value = new FhirUri(reader.GetString());
          }
          break;

        case "_valueUri":
          if (current.Value == null) { current.Value = new FhirUri(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueUrl":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new FhirUrl();
            reader.Skip();
          }
          else
          {
            current.Value = new FhirUrl(reader.GetString());
          }
          break;

        case "_valueUrl":
          if (current.Value == null) { current.Value = new FhirUrl(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueUuid":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Value = new Uuid();
            reader.Skip();
          }
          else
          {
            current.Value = new Uuid(reader.GetString());
          }
          break;

        case "_valueUuid":
          if (current.Value == null) { current.Value = new Uuid(); }
          ((Hl7.Fhir.Model.Element)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueAddress":
          current.Value = new Hl7.Fhir.Model.Address();
          ((Hl7.Fhir.Model.Address)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueAge":
          current.Value = new Hl7.Fhir.Model.Age();
          ((Hl7.Fhir.Model.Age)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueAnnotation":
          current.Value = new Hl7.Fhir.Model.Annotation();
          ((Hl7.Fhir.Model.Annotation)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueAttachment":
          current.Value = new Hl7.Fhir.Model.Attachment();
          ((Hl7.Fhir.Model.Attachment)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          current.Value = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueCoding":
          current.Value = new Hl7.Fhir.Model.Coding();
          ((Hl7.Fhir.Model.Coding)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueContactPoint":
          current.Value = new Hl7.Fhir.Model.ContactPoint();
          ((Hl7.Fhir.Model.ContactPoint)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueCount":
          current.Value = new Hl7.Fhir.Model.Count();
          ((Hl7.Fhir.Model.Count)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueDistance":
          current.Value = new Hl7.Fhir.Model.Distance();
          ((Hl7.Fhir.Model.Distance)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueDuration":
          current.Value = new Hl7.Fhir.Model.Duration();
          ((Hl7.Fhir.Model.Duration)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueHumanName":
          current.Value = new Hl7.Fhir.Model.HumanName();
          ((Hl7.Fhir.Model.HumanName)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueIdentifier":
          current.Value = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueMoney":
          current.Value = new Hl7.Fhir.Model.Money();
          ((Hl7.Fhir.Model.Money)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valuePeriod":
          current.Value = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          current.Value = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueRange":
          current.Value = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueRatio":
          current.Value = new Hl7.Fhir.Model.Ratio();
          ((Hl7.Fhir.Model.Ratio)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueReference":
          current.Value = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueSampledData":
          current.Value = new Hl7.Fhir.Model.SampledData();
          ((Hl7.Fhir.Model.SampledData)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueSignature":
          current.Value = new Hl7.Fhir.Model.Signature();
          ((Hl7.Fhir.Model.Signature)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueTiming":
          current.Value = new Hl7.Fhir.Model.Timing();
          ((Hl7.Fhir.Model.Timing)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueContactDetail":
          current.Value = new Hl7.Fhir.Model.ContactDetail();
          ((Hl7.Fhir.Model.ContactDetail)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueContributor":
          current.Value = new Hl7.Fhir.Model.Contributor();
          ((Hl7.Fhir.Model.Contributor)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueDataRequirement":
          current.Value = new Hl7.Fhir.Model.DataRequirement();
          ((Hl7.Fhir.Model.DataRequirement)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueExpression":
          current.Value = new Hl7.Fhir.Model.Expression();
          ((Hl7.Fhir.Model.Expression)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueParameterDefinition":
          current.Value = new Hl7.Fhir.Model.ParameterDefinition();
          ((Hl7.Fhir.Model.ParameterDefinition)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueRelatedArtifact":
          current.Value = new Hl7.Fhir.Model.RelatedArtifact();
          ((Hl7.Fhir.Model.RelatedArtifact)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueTriggerDefinition":
          current.Value = new Hl7.Fhir.Model.TriggerDefinition();
          ((Hl7.Fhir.Model.TriggerDefinition)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueUsageContext":
          current.Value = new Hl7.Fhir.Model.UsageContext();
          ((Hl7.Fhir.Model.UsageContext)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueDosage":
          current.Value = new Hl7.Fhir.Model.Dosage();
          ((Hl7.Fhir.Model.Dosage)current.Value).DeserializeJson(ref reader, options);
          break;

        case "valueMeta":
          current.Value = new Hl7.Fhir.Model.Meta();
          ((Hl7.Fhir.Model.Meta)current.Value).DeserializeJson(ref reader, options);
          break;

        case "resource":
          current.Resource = JsonStreamResourceConverter.PolymorphicRead(ref reader, options);
          break;

        case "part":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ParameterComponent error reading 'part' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Part = new List<Parameters.ParameterComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Parameters.ParameterComponent v_Part = new Hl7.Fhir.Model.Parameters.ParameterComponent();
            v_Part.DeserializeJson(ref reader, options);
            current.Part.Add(v_Part);

            if (!reader.Read())
            {
              throw new JsonException($"ParameterComponent error reading 'part' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Part.Count == 0)
          {
            current.Part = null;
          }
          break;

        // Complex: parameter, Export: ParameterComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ParametersJsonConverter : JsonConverter<Hl7.Fhir.Model.Parameters>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Parameters value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Parameters Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Parameters();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
