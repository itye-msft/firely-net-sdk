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
  /// JSON Serialization Extensions for Appointment
  /// </summary>
  public static class AppointmentSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Appointment into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Appointment current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Appointment");
      // Complex: Appointment, Export: Appointment, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("cancelationReason", current.CancelationReason, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("serviceCategory", current.ServiceCategory, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("serviceType", current.ServiceType, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("specialty", current.Specialty, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("appointmentType", current.AppointmentType, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("reasonCode", current.ReasonCode, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("reasonReference", current.ReasonReference, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("priority",current.PriorityElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("description",current.DescriptionElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("supportingInformation", current.SupportingInformation, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("start",current.StartElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("end",current.EndElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("minutesDuration",current.MinutesDurationElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("slot", current.Slot, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("created",current.CreatedElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("comment",current.CommentElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("patientInstruction",current.PatientInstructionElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("basedOn", current.BasedOn, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("participant", current.Participant, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("requestedPeriod", current.RequestedPeriod, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Appointment
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Appointment current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Appointment >>> Appointment.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Appointment: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Appointment
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Appointment current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Appointment.AppointmentStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Appointment.AppointmentStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Appointment.AppointmentStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.Appointment.AppointmentStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "cancelationReason":
          current.CancelationReason = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.CancelationReason).DeserializeJson(ref reader, options);
          break;

        case "serviceCategory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'serviceCategory' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ServiceCategory = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ServiceCategory = new Hl7.Fhir.Model.CodeableConcept();
            v_ServiceCategory.DeserializeJson(ref reader, options);
            current.ServiceCategory.Add(v_ServiceCategory);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'serviceCategory' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ServiceCategory.Count == 0)
          {
            current.ServiceCategory = null;
          }
          break;

        case "serviceType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'serviceType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ServiceType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ServiceType = new Hl7.Fhir.Model.CodeableConcept();
            v_ServiceType.DeserializeJson(ref reader, options);
            current.ServiceType.Add(v_ServiceType);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'serviceType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ServiceType.Count == 0)
          {
            current.ServiceType = null;
          }
          break;

        case "specialty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'specialty' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Specialty = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Specialty = new Hl7.Fhir.Model.CodeableConcept();
            v_Specialty.DeserializeJson(ref reader, options);
            current.Specialty.Add(v_Specialty);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'specialty' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Specialty.Count == 0)
          {
            current.Specialty = null;
          }
          break;

        case "appointmentType":
          current.AppointmentType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.AppointmentType).DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'reasonCode' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
            v_ReasonCode.DeserializeJson(ref reader, options);
            current.ReasonCode.Add(v_ReasonCode);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'reasonCode' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonCode.Count == 0)
          {
            current.ReasonCode = null;
          }
          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'reasonReference' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ReasonReference = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ReasonReference = new Hl7.Fhir.Model.ResourceReference();
            v_ReasonReference.DeserializeJson(ref reader, options);
            current.ReasonReference.Add(v_ReasonReference);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'reasonReference' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonReference.Count == 0)
          {
            current.ReasonReference = null;
          }
          break;

        case "priority":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PriorityElement = new UnsignedInt();
            reader.Skip();
          }
          else
          {
            current.PriorityElement = new UnsignedInt(reader.GetInt32());
          }
          break;

        case "_priority":
          if (current.PriorityElement == null) { current.PriorityElement = new UnsignedInt(); }
          ((Hl7.Fhir.Model.Element)current.PriorityElement).DeserializeJson(ref reader, options);
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

        case "supportingInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'supportingInformation' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.SupportingInformation = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_SupportingInformation = new Hl7.Fhir.Model.ResourceReference();
            v_SupportingInformation.DeserializeJson(ref reader, options);
            current.SupportingInformation.Add(v_SupportingInformation);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'supportingInformation' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.SupportingInformation.Count == 0)
          {
            current.SupportingInformation = null;
          }
          break;

        case "start":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StartElement = new Instant();
            reader.Skip();
          }
          else
          {
            current.StartElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_start":
          if (current.StartElement == null) { current.StartElement = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.StartElement).DeserializeJson(ref reader, options);
          break;

        case "end":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.EndElement = new Instant();
            reader.Skip();
          }
          else
          {
            current.EndElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_end":
          if (current.EndElement == null) { current.EndElement = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.EndElement).DeserializeJson(ref reader, options);
          break;

        case "minutesDuration":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.MinutesDurationElement = new PositiveInt();
            reader.Skip();
          }
          else
          {
            current.MinutesDurationElement = new PositiveInt(reader.GetInt32());
          }
          break;

        case "_minutesDuration":
          if (current.MinutesDurationElement == null) { current.MinutesDurationElement = new PositiveInt(); }
          ((Hl7.Fhir.Model.Element)current.MinutesDurationElement).DeserializeJson(ref reader, options);
          break;

        case "slot":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'slot' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Slot = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Slot = new Hl7.Fhir.Model.ResourceReference();
            v_Slot.DeserializeJson(ref reader, options);
            current.Slot.Add(v_Slot);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'slot' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Slot.Count == 0)
          {
            current.Slot = null;
          }
          break;

        case "created":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CreatedElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.CreatedElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_created":
          if (current.CreatedElement == null) { current.CreatedElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.CreatedElement).DeserializeJson(ref reader, options);
          break;

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

        case "patientInstruction":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PatientInstructionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.PatientInstructionElement = new FhirString(reader.GetString());
          }
          break;

        case "_patientInstruction":
          if (current.PatientInstructionElement == null) { current.PatientInstructionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.PatientInstructionElement).DeserializeJson(ref reader, options);
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'basedOn' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.BasedOn = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_BasedOn = new Hl7.Fhir.Model.ResourceReference();
            v_BasedOn.DeserializeJson(ref reader, options);
            current.BasedOn.Add(v_BasedOn);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'basedOn' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.BasedOn.Count == 0)
          {
            current.BasedOn = null;
          }
          break;

        case "participant":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'participant' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Participant = new List<Appointment.ParticipantComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Appointment.ParticipantComponent v_Participant = new Hl7.Fhir.Model.Appointment.ParticipantComponent();
            v_Participant.DeserializeJson(ref reader, options);
            current.Participant.Add(v_Participant);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'participant' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Participant.Count == 0)
          {
            current.Participant = null;
          }
          break;

        case "requestedPeriod":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Appointment error reading 'requestedPeriod' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.RequestedPeriod = new List<Period>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Period v_RequestedPeriod = new Hl7.Fhir.Model.Period();
            v_RequestedPeriod.DeserializeJson(ref reader, options);
            current.RequestedPeriod.Add(v_RequestedPeriod);

            if (!reader.Read())
            {
              throw new JsonException($"Appointment error reading 'requestedPeriod' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.RequestedPeriod.Count == 0)
          {
            current.RequestedPeriod = null;
          }
          break;

        // Complex: Appointment, Export: Appointment, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Appointment#Participant into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Appointment.ParticipantComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Appointment#Participant, Export: ParticipantComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("actor", current.Actor, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("required",current.RequiredElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("period", current.Period, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Appointment#Participant
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Appointment.ParticipantComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Appointment.ParticipantComponent >>> Appointment#Participant.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Appointment.ParticipantComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Appointment#Participant
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Appointment.ParticipantComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ParticipantComponent error reading 'type' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Type = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Type = new Hl7.Fhir.Model.CodeableConcept();
            v_Type.DeserializeJson(ref reader, options);
            current.Type.Add(v_Type);

            if (!reader.Read())
            {
              throw new JsonException($"ParticipantComponent error reading 'type' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Type.Count == 0)
          {
            current.Type = null;
          }
          break;

        case "actor":
          current.Actor = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Actor).DeserializeJson(ref reader, options);
          break;

        case "required":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.RequiredElement = new Code<Hl7.Fhir.Model.Appointment.ParticipantRequired>();
            reader.Skip();
          }
          else
          {
            current.RequiredElement = new Code<Hl7.Fhir.Model.Appointment.ParticipantRequired>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Appointment.ParticipantRequired>(reader.GetString()));
          }
          break;

        case "_required":
          if (current.RequiredElement == null) { current.RequiredElement = new Code<Hl7.Fhir.Model.Appointment.ParticipantRequired>(); }
          ((Hl7.Fhir.Model.Element)current.RequiredElement).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.ParticipationStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.ParticipationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ParticipationStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.ParticipationStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        // Complex: participant, Export: ParticipantComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class AppointmentJsonConverter : JsonConverter<Hl7.Fhir.Model.Appointment>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Appointment value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Appointment Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Appointment();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
