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
  /// JSON Serialization Extensions for Subscription
  /// </summary>
  public static class SubscriptionSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR Subscription into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Subscription current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Subscription");
      // Complex: Subscription, Export: Subscription, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("status",current.StatusElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("contact", current.Contact, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("end",current.EndElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("reason",current.ReasonElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("criteria",current.CriteriaElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("error",current.ErrorElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("channel", current.Channel, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Subscription
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Subscription current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Subscription >>> Subscription.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Subscription: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Subscription
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Subscription current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Subscription.SubscriptionStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.Subscription.SubscriptionStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Subscription error reading 'contact' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Contact = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactPoint v_Contact = new Hl7.Fhir.Model.ContactPoint();
            v_Contact.DeserializeJson(ref reader, options);
            current.Contact.Add(v_Contact);

            if (!reader.Read())
            {
              throw new JsonException($"Subscription error reading 'contact' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Contact.Count == 0)
          {
            current.Contact = null;
          }
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

        case "reason":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ReasonElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ReasonElement = new FhirString(reader.GetString());
          }
          break;

        case "_reason":
          if (current.ReasonElement == null) { current.ReasonElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ReasonElement).DeserializeJson(ref reader, options);
          break;

        case "criteria":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CriteriaElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.CriteriaElement = new FhirString(reader.GetString());
          }
          break;

        case "_criteria":
          if (current.CriteriaElement == null) { current.CriteriaElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.CriteriaElement).DeserializeJson(ref reader, options);
          break;

        case "error":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ErrorElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ErrorElement = new FhirString(reader.GetString());
          }
          break;

        case "_error":
          if (current.ErrorElement == null) { current.ErrorElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ErrorElement).DeserializeJson(ref reader, options);
          break;

        case "channel":
          current.Channel = new Hl7.Fhir.Model.Subscription.ChannelComponent();
          ((Hl7.Fhir.Model.Subscription.ChannelComponent)current.Channel).DeserializeJson(ref reader, options);
          break;

        // Complex: Subscription, Export: Subscription, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR Subscription#Channel into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.Subscription.ChannelComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: Subscription#Channel, Export: ChannelComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializePrimitiveProperty("type",current.TypeElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("endpoint",current.EndpointElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("payload",current.PayloadElement,writer,options);

      JsonStreamUtilities.SerializePrimitiveProperty("header",current.HeaderElement,writer,options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Subscription#Channel
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.Subscription.ChannelComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Subscription.ChannelComponent >>> Subscription#Channel.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Subscription.ChannelComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Subscription#Channel
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.Subscription.ChannelComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.Subscription.SubscriptionChannelType>();
            reader.Skip();
          }
          else
          {
            current.TypeElement = new Code<Hl7.Fhir.Model.Subscription.SubscriptionChannelType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Subscription.SubscriptionChannelType>(reader.GetString()));
          }
          break;

        case "_type":
          if (current.TypeElement == null) { current.TypeElement = new Code<Hl7.Fhir.Model.Subscription.SubscriptionChannelType>(); }
          ((Hl7.Fhir.Model.Element)current.TypeElement).DeserializeJson(ref reader, options);
          break;

        case "endpoint":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.EndpointElement = new FhirUrl();
            reader.Skip();
          }
          else
          {
            current.EndpointElement = new FhirUrl(reader.GetString());
          }
          break;

        case "_endpoint":
          if (current.EndpointElement == null) { current.EndpointElement = new FhirUrl(); }
          ((Hl7.Fhir.Model.Element)current.EndpointElement).DeserializeJson(ref reader, options);
          break;

        case "payload":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PayloadElement = new Code();
            reader.Skip();
          }
          else
          {
            current.PayloadElement = new Code(reader.GetString());
          }
          break;

        case "_payload":
          if (current.PayloadElement == null) { current.PayloadElement = new Code(); }
          ((Hl7.Fhir.Model.Element)current.PayloadElement).DeserializeJson(ref reader, options);
          break;

        case "header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ChannelComponent error reading 'header' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.HeaderElement = new List<FhirString>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.HeaderElement.Add(new FhirString());
              reader.Skip();
            }
            else
            {
              current.HeaderElement.Add(new FhirString(reader.GetString()));
            }

            if (!reader.Read())
            {
              throw new JsonException($"ChannelComponent error reading 'header' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.HeaderElement.Count == 0)
          {
            current.HeaderElement = null;
          }
          break;

        case "_header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ChannelComponent error reading 'header' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_header = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_header >= current.HeaderElement.Count)
            {
              current.HeaderElement.Add(new FhirString());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.HeaderElement[i_header++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"ChannelComponent error reading 'header' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        // Complex: channel, Export: ChannelComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SubscriptionJsonConverter : JsonConverter<Hl7.Fhir.Model.Subscription>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.Subscription value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.Subscription Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.Subscription();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
