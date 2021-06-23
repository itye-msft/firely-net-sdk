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
  /// JSON Serialization Extensions for VerificationResult
  /// </summary>
  public static class VerificationResultSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR VerificationResult into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.VerificationResult current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","VerificationResult");
      // Complex: VerificationResult, Export: VerificationResult, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("target", current.Target, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("targetLocation",current.TargetLocationElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("need", current.Need, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.Status_Element,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("statusDate",current.StatusDateElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("validationType", current.ValidationType, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("validationProcess", current.ValidationProcess, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("frequency", current.Frequency, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("lastPerformed",current.LastPerformedElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("nextScheduled",current.NextScheduledElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("failureAction", current.FailureAction, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("primarySource", current.PrimarySource, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("attestation", current.Attestation, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("validator", current.Validator, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.VerificationResult current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"VerificationResult >>> VerificationResult.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"VerificationResult: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.VerificationResult current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "target":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VerificationResult error reading 'target' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Target = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Target = new Hl7.Fhir.Model.ResourceReference();
            v_Target.DeserializeJson(ref reader, options);
            current.Target.Add(v_Target);

            if (!reader.Read())
            {
              throw new JsonException($"VerificationResult error reading 'target' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Target.Count == 0)
          {
            current.Target = null;
          }
          break;

        case "targetLocation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VerificationResult error reading 'targetLocation' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.TargetLocationElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.TargetLocationElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.TargetLocationElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"VerificationResult error reading 'targetLocation' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.TargetLocationElement.Count == 0)
          {
            current.TargetLocationElement = null;
          }
          break;

        case "_targetLocation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VerificationResult error reading 'targetLocation' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_targetLocation = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_targetLocation >= current.TargetLocationElement.Count)
            {
              current.TargetLocationElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.TargetLocationElement[i_targetLocation++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"VerificationResult error reading 'targetLocation' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "need":
          current.Need = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Need).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Status_Element = new Code<Hl7.Fhir.Model.VerificationResult.status>();
            reader.Skip();
          }
          else
          {
            current.Status_Element = new Code<Hl7.Fhir.Model.VerificationResult.status>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.VerificationResult.status>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.Status_Element == null) { current.Status_Element = new Code<Hl7.Fhir.Model.VerificationResult.status>(); }
          ((Hl7.Fhir.Model.Element)current.Status_Element).DeserializeJson(ref reader, options);
          break;

        case "statusDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusDateElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.StatusDateElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_statusDate":
          if (current.StatusDateElement == null) { current.StatusDateElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.StatusDateElement).DeserializeJson(ref reader, options);
          break;

        case "validationType":
          current.ValidationType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.ValidationType).DeserializeJson(ref reader, options);
          break;

        case "validationProcess":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VerificationResult error reading 'validationProcess' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ValidationProcess = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ValidationProcess = new Hl7.Fhir.Model.CodeableConcept();
            v_ValidationProcess.DeserializeJson(ref reader, options);
            current.ValidationProcess.Add(v_ValidationProcess);

            if (!reader.Read())
            {
              throw new JsonException($"VerificationResult error reading 'validationProcess' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ValidationProcess.Count == 0)
          {
            current.ValidationProcess = null;
          }
          break;

        case "frequency":
          current.Frequency = new Hl7.Fhir.Model.Timing();
          ((Hl7.Fhir.Model.Timing)current.Frequency).DeserializeJson(ref reader, options);
          break;

        case "lastPerformed":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.LastPerformedElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.LastPerformedElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_lastPerformed":
          if (current.LastPerformedElement == null) { current.LastPerformedElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.LastPerformedElement).DeserializeJson(ref reader, options);
          break;

        case "nextScheduled":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.NextScheduledElement = new Date();
            reader.Skip();
          }
          else
          {
            current.NextScheduledElement = new Date(reader.GetString());
          }
          break;

        case "_nextScheduled":
          if (current.NextScheduledElement == null) { current.NextScheduledElement = new Date(); }
          ((Hl7.Fhir.Model.Element)current.NextScheduledElement).DeserializeJson(ref reader, options);
          break;

        case "failureAction":
          current.FailureAction = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.FailureAction).DeserializeJson(ref reader, options);
          break;

        case "primarySource":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VerificationResult error reading 'primarySource' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PrimarySource = new List<VerificationResult.PrimarySourceComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent v_PrimarySource = new Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent();
            v_PrimarySource.DeserializeJson(ref reader, options);
            current.PrimarySource.Add(v_PrimarySource);

            if (!reader.Read())
            {
              throw new JsonException($"VerificationResult error reading 'primarySource' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PrimarySource.Count == 0)
          {
            current.PrimarySource = null;
          }
          break;

        case "attestation":
          current.Attestation = new Hl7.Fhir.Model.VerificationResult.AttestationComponent();
          ((Hl7.Fhir.Model.VerificationResult.AttestationComponent)current.Attestation).DeserializeJson(ref reader, options);
          break;

        case "validator":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"VerificationResult error reading 'validator' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Validator = new List<VerificationResult.ValidatorComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.VerificationResult.ValidatorComponent v_Validator = new Hl7.Fhir.Model.VerificationResult.ValidatorComponent();
            v_Validator.DeserializeJson(ref reader, options);
            current.Validator.Add(v_Validator);

            if (!reader.Read())
            {
              throw new JsonException($"VerificationResult error reading 'validator' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Validator.Count == 0)
          {
            current.Validator = null;
          }
          break;

        // Complex: VerificationResult, Export: VerificationResult, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR VerificationResult#PrimarySource into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: VerificationResult#PrimarySource, Export: PrimarySourceComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("who", current.Who, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("communicationMethod", current.CommunicationMethod, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("validationStatus", current.ValidationStatus, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("validationDate",current.ValidationDateElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("canPushUpdates", current.CanPushUpdates, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("pushTypeAvailable", current.PushTypeAvailable, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult#PrimarySource
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"VerificationResult.PrimarySourceComponent >>> VerificationResult#PrimarySource.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"VerificationResult.PrimarySourceComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult#PrimarySource
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.VerificationResult.PrimarySourceComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "who":
          current.Who = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Who).DeserializeJson(ref reader, options);
          break;

        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PrimarySourceComponent error reading 'type' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Type = new Hl7.Fhir.Model.CodeableConcept();
            v_Type.DeserializeJson(ref reader, options);
            current.Type.Add(v_Type);

            if (!reader.Read())
            {
              throw new JsonException($"PrimarySourceComponent error reading 'type' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Type.Count == 0)
          {
            current.Type = null;
          }
          break;

        case "communicationMethod":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PrimarySourceComponent error reading 'communicationMethod' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.CommunicationMethod = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_CommunicationMethod = new Hl7.Fhir.Model.CodeableConcept();
            v_CommunicationMethod.DeserializeJson(ref reader, options);
            current.CommunicationMethod.Add(v_CommunicationMethod);

            if (!reader.Read())
            {
              throw new JsonException($"PrimarySourceComponent error reading 'communicationMethod' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.CommunicationMethod.Count == 0)
          {
            current.CommunicationMethod = null;
          }
          break;

        case "validationStatus":
          current.ValidationStatus = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.ValidationStatus).DeserializeJson(ref reader, options);
          break;

        case "validationDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ValidationDateElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.ValidationDateElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_validationDate":
          if (current.ValidationDateElement == null) { current.ValidationDateElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.ValidationDateElement).DeserializeJson(ref reader, options);
          break;

        case "canPushUpdates":
          current.CanPushUpdates = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.CanPushUpdates).DeserializeJson(ref reader, options);
          break;

        case "pushTypeAvailable":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PrimarySourceComponent error reading 'pushTypeAvailable' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PushTypeAvailable = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_PushTypeAvailable = new Hl7.Fhir.Model.CodeableConcept();
            v_PushTypeAvailable.DeserializeJson(ref reader, options);
            current.PushTypeAvailable.Add(v_PushTypeAvailable);

            if (!reader.Read())
            {
              throw new JsonException($"PrimarySourceComponent error reading 'pushTypeAvailable' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PushTypeAvailable.Count == 0)
          {
            current.PushTypeAvailable = null;
          }
          break;

        // Complex: primarySource, Export: PrimarySourceComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR VerificationResult#Attestation into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.VerificationResult.AttestationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: VerificationResult#Attestation, Export: AttestationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("who", current.Who, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("onBehalfOf", current.OnBehalfOf, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("communicationMethod", current.CommunicationMethod, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("date",current.DateElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("sourceIdentityCertificate",current.SourceIdentityCertificateElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("proxyIdentityCertificate",current.ProxyIdentityCertificateElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("proxySignature", current.ProxySignature, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("sourceSignature", current.SourceSignature, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult#Attestation
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.VerificationResult.AttestationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"VerificationResult.AttestationComponent >>> VerificationResult#Attestation.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"VerificationResult.AttestationComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult#Attestation
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.VerificationResult.AttestationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "who":
          current.Who = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Who).DeserializeJson(ref reader, options);
          break;

        case "onBehalfOf":
          current.OnBehalfOf = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.OnBehalfOf).DeserializeJson(ref reader, options);
          break;

        case "communicationMethod":
          current.CommunicationMethod = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.CommunicationMethod).DeserializeJson(ref reader, options);
          break;

        case "date":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DateElement = new Date();
            reader.Skip();
          }
          else
          {
            current.DateElement = new Date(reader.GetString());
          }
          break;

        case "_date":
          if (current.DateElement == null) { current.DateElement = new Date(); }
          ((Hl7.Fhir.Model.Element)current.DateElement).DeserializeJson(ref reader, options);
          break;

        case "sourceIdentityCertificate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SourceIdentityCertificateElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.SourceIdentityCertificateElement = new FhirString(reader.GetString());
          }
          break;

        case "_sourceIdentityCertificate":
          if (current.SourceIdentityCertificateElement == null) { current.SourceIdentityCertificateElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.SourceIdentityCertificateElement).DeserializeJson(ref reader, options);
          break;

        case "proxyIdentityCertificate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ProxyIdentityCertificateElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ProxyIdentityCertificateElement = new FhirString(reader.GetString());
          }
          break;

        case "_proxyIdentityCertificate":
          if (current.ProxyIdentityCertificateElement == null) { current.ProxyIdentityCertificateElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ProxyIdentityCertificateElement).DeserializeJson(ref reader, options);
          break;

        case "proxySignature":
          current.ProxySignature = new Hl7.Fhir.Model.Signature();
          ((Hl7.Fhir.Model.Signature)current.ProxySignature).DeserializeJson(ref reader, options);
          break;

        case "sourceSignature":
          current.SourceSignature = new Hl7.Fhir.Model.Signature();
          ((Hl7.Fhir.Model.Signature)current.SourceSignature).DeserializeJson(ref reader, options);
          break;

        // Complex: attestation, Export: AttestationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR VerificationResult#Validator into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.VerificationResult.ValidatorComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: VerificationResult#Validator, Export: ValidatorComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("organization", current.Organization, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("identityCertificate",current.IdentityCertificateElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("attestationSignature", current.AttestationSignature, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult#Validator
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.VerificationResult.ValidatorComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"VerificationResult.ValidatorComponent >>> VerificationResult#Validator.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"VerificationResult.ValidatorComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR VerificationResult#Validator
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.VerificationResult.ValidatorComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "organization":
          current.Organization = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Organization).DeserializeJson(ref reader, options);
          break;

        case "identityCertificate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.IdentityCertificateElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.IdentityCertificateElement = new FhirString(reader.GetString());
          }
          break;

        case "_identityCertificate":
          if (current.IdentityCertificateElement == null) { current.IdentityCertificateElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.IdentityCertificateElement).DeserializeJson(ref reader, options);
          break;

        case "attestationSignature":
          current.AttestationSignature = new Hl7.Fhir.Model.Signature();
          ((Hl7.Fhir.Model.Signature)current.AttestationSignature).DeserializeJson(ref reader, options);
          break;

        // Complex: validator, Export: ValidatorComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class VerificationResultJsonConverter : JsonConverter<Hl7.Fhir.Model.VerificationResult>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.VerificationResult value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.VerificationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.VerificationResult();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
