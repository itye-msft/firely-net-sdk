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
  /// JSON Serialization Extensions for MedicinalProductPackaged
  /// </summary>
  public static class MedicinalProductPackagedSerializationExtensions
  {
    /// <summary>
    /// Serialize a FHIR MedicinalProductPackaged into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.MedicinalProductPackaged current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MedicinalProductPackaged");
      // Complex: MedicinalProductPackaged, Export: MedicinalProductPackaged, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("subject", current.Subject, writer, options);

      JsonStreamUtilities.SerializePrimitiveProperty("description",current.DescriptionElement,writer,options);

      JsonStreamUtilities.SerializeComplexProperty("legalStatusOfSupply", current.LegalStatusOfSupply, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("marketingStatus", current.MarketingStatus, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("marketingAuthorization", current.MarketingAuthorization, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("manufacturer", current.Manufacturer, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("batchIdentifier", current.BatchIdentifier, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("packageItem", current.PackageItem, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductPackaged
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.MedicinalProductPackaged current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductPackaged >>> MedicinalProductPackaged.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductPackaged: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductPackaged
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.MedicinalProductPackaged current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductPackaged error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductPackaged error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductPackaged error reading 'subject' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Subject = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Subject = new Hl7.Fhir.Model.ResourceReference();
            v_Subject.DeserializeJson(ref reader, options);
            current.Subject.Add(v_Subject);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductPackaged error reading 'subject' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Subject.Count == 0)
          {
            current.Subject = null;
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

        case "legalStatusOfSupply":
          current.LegalStatusOfSupply = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.LegalStatusOfSupply).DeserializeJson(ref reader, options);
          break;

        case "marketingStatus":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductPackaged error reading 'marketingStatus' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.MarketingStatus = new List<MarketingStatus>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MarketingStatus v_MarketingStatus = new Hl7.Fhir.Model.MarketingStatus();
            v_MarketingStatus.DeserializeJson(ref reader, options);
            current.MarketingStatus.Add(v_MarketingStatus);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductPackaged error reading 'marketingStatus' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.MarketingStatus.Count == 0)
          {
            current.MarketingStatus = null;
          }
          break;

        case "marketingAuthorization":
          current.MarketingAuthorization = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.MarketingAuthorization).DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductPackaged error reading 'manufacturer' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Manufacturer = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Manufacturer = new Hl7.Fhir.Model.ResourceReference();
            v_Manufacturer.DeserializeJson(ref reader, options);
            current.Manufacturer.Add(v_Manufacturer);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductPackaged error reading 'manufacturer' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Manufacturer.Count == 0)
          {
            current.Manufacturer = null;
          }
          break;

        case "batchIdentifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductPackaged error reading 'batchIdentifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.BatchIdentifier = new List<MedicinalProductPackaged.BatchIdentifierComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent v_BatchIdentifier = new Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent();
            v_BatchIdentifier.DeserializeJson(ref reader, options);
            current.BatchIdentifier.Add(v_BatchIdentifier);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductPackaged error reading 'batchIdentifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.BatchIdentifier.Count == 0)
          {
            current.BatchIdentifier = null;
          }
          break;

        case "packageItem":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductPackaged error reading 'packageItem' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent v_PackageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
            v_PackageItem.DeserializeJson(ref reader, options);
            current.PackageItem.Add(v_PackageItem);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductPackaged error reading 'packageItem' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PackageItem.Count == 0)
          {
            current.PackageItem = null;
          }
          break;

        // Complex: MedicinalProductPackaged, Export: MedicinalProductPackaged, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductPackaged#BatchIdentifier into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductPackaged#BatchIdentifier, Export: BatchIdentifierComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("outerPackaging", current.OuterPackaging, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("immediatePackaging", current.ImmediatePackaging, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductPackaged#BatchIdentifier
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductPackaged.BatchIdentifierComponent >>> MedicinalProductPackaged#BatchIdentifier.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductPackaged.BatchIdentifierComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductPackaged#BatchIdentifier
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.MedicinalProductPackaged.BatchIdentifierComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "outerPackaging":
          current.OuterPackaging = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.OuterPackaging).DeserializeJson(ref reader, options);
          break;

        case "immediatePackaging":
          current.ImmediatePackaging = new Hl7.Fhir.Model.Identifier();
          ((Hl7.Fhir.Model.Identifier)current.ImmediatePackaging).DeserializeJson(ref reader, options);
          break;

        // Complex: batchIdentifier, Export: BatchIdentifierComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR MedicinalProductPackaged#PackageItem into JSON
    /// </summary>
    public static void SerializeJson(this Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: MedicinalProductPackaged#PackageItem, Export: PackageItemComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      JsonStreamUtilities.SerializeComplexProperty("identifier", current.Identifier, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("type", current.Type, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("quantity", current.Quantity, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("material", current.Material, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("alternateMaterial", current.AlternateMaterial, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("device", current.Device, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("manufacturedItem", current.ManufacturedItem, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("packageItem", current.PackageItem, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("physicalCharacteristics", current.PhysicalCharacteristics, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("otherCharacteristics", current.OtherCharacteristics, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("shelfLifeStorage", current.ShelfLifeStorage, writer, options);

      JsonStreamUtilities.SerializeComplexProperty("manufacturer", current.Manufacturer, writer, options);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductPackaged#PackageItem
    /// </summary>
    public static void DeserializeJson(this Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductPackaged.PackageItemComponent >>> MedicinalProductPackaged#PackageItem.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductPackaged.PackageItemComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductPackaged#PackageItem
    /// </summary>
    public static void DeserializeJsonProperty(this Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Type).DeserializeJson(ref reader, options);
          break;

        case "quantity":
          current.Quantity = new Hl7.Fhir.Model.Quantity();
          ((Hl7.Fhir.Model.Quantity)current.Quantity).DeserializeJson(ref reader, options);
          break;

        case "material":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'material' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Material = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Material = new Hl7.Fhir.Model.CodeableConcept();
            v_Material.DeserializeJson(ref reader, options);
            current.Material.Add(v_Material);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'material' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Material.Count == 0)
          {
            current.Material = null;
          }
          break;

        case "alternateMaterial":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'alternateMaterial' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.AlternateMaterial = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_AlternateMaterial = new Hl7.Fhir.Model.CodeableConcept();
            v_AlternateMaterial.DeserializeJson(ref reader, options);
            current.AlternateMaterial.Add(v_AlternateMaterial);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'alternateMaterial' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.AlternateMaterial.Count == 0)
          {
            current.AlternateMaterial = null;
          }
          break;

        case "device":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'device' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Device = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Device = new Hl7.Fhir.Model.ResourceReference();
            v_Device.DeserializeJson(ref reader, options);
            current.Device.Add(v_Device);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'device' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Device.Count == 0)
          {
            current.Device = null;
          }
          break;

        case "manufacturedItem":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'manufacturedItem' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ManufacturedItem = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_ManufacturedItem = new Hl7.Fhir.Model.ResourceReference();
            v_ManufacturedItem.DeserializeJson(ref reader, options);
            current.ManufacturedItem.Add(v_ManufacturedItem);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'manufacturedItem' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ManufacturedItem.Count == 0)
          {
            current.ManufacturedItem = null;
          }
          break;

        case "packageItem":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'packageItem' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PackageItem = new List<MedicinalProductPackaged.PackageItemComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent v_PackageItem = new Hl7.Fhir.Model.MedicinalProductPackaged.PackageItemComponent();
            v_PackageItem.DeserializeJson(ref reader, options);
            current.PackageItem.Add(v_PackageItem);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'packageItem' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PackageItem.Count == 0)
          {
            current.PackageItem = null;
          }
          break;

        case "physicalCharacteristics":
          current.PhysicalCharacteristics = new Hl7.Fhir.Model.ProdCharacteristic();
          ((Hl7.Fhir.Model.ProdCharacteristic)current.PhysicalCharacteristics).DeserializeJson(ref reader, options);
          break;

        case "otherCharacteristics":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'otherCharacteristics' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.OtherCharacteristics = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_OtherCharacteristics = new Hl7.Fhir.Model.CodeableConcept();
            v_OtherCharacteristics.DeserializeJson(ref reader, options);
            current.OtherCharacteristics.Add(v_OtherCharacteristics);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'otherCharacteristics' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.OtherCharacteristics.Count == 0)
          {
            current.OtherCharacteristics = null;
          }
          break;

        case "shelfLifeStorage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'shelfLifeStorage' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ShelfLifeStorage = new List<ProductShelfLife>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ProductShelfLife v_ShelfLifeStorage = new Hl7.Fhir.Model.ProductShelfLife();
            v_ShelfLifeStorage.DeserializeJson(ref reader, options);
            current.ShelfLifeStorage.Add(v_ShelfLifeStorage);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'shelfLifeStorage' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ShelfLifeStorage.Count == 0)
          {
            current.ShelfLifeStorage = null;
          }
          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PackageItemComponent error reading 'manufacturer' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Manufacturer = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Manufacturer = new Hl7.Fhir.Model.ResourceReference();
            v_Manufacturer.DeserializeJson(ref reader, options);
            current.Manufacturer.Add(v_Manufacturer);

            if (!reader.Read())
            {
              throw new JsonException($"PackageItemComponent error reading 'manufacturer' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Manufacturer.Count == 0)
          {
            current.Manufacturer = null;
          }
          break;

        // Complex: packageItem, Export: PackageItemComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicinalProductPackagedJsonConverter : JsonConverter<Hl7.Fhir.Model.MedicinalProductPackaged>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Hl7.Fhir.Model.MedicinalProductPackaged value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Hl7.Fhir.Model.MedicinalProductPackaged Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        var target = new Hl7.Fhir.Model.MedicinalProductPackaged();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
