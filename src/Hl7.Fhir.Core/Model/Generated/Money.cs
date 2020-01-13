﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Specification;

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

//
// Generated for FHIR v4.2.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An amount of economic utility in some recognized currency
    /// </summary>
    [FhirType("Money")]
    [DataContract]
    public partial class Money : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "Money"; } }
        
        /// <summary>
        /// Currency codes from ISO 4217 (see https://www.iso.org/iso-4217-currency-codes.html)
        /// (url: http://hl7.org/fhir/ValueSet/currencies)
        /// </summary>
        [FhirEnumeration("Currencies")]
        public enum Currencies
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("AED", "urn:iso:std:iso:4217"), Description("United Arab Emirates dirham")]
            AED,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("AFN", "urn:iso:std:iso:4217"), Description("Afghan afghani")]
            AFN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ALL", "urn:iso:std:iso:4217"), Description("Albanian lek")]
            ALL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("AMD", "urn:iso:std:iso:4217"), Description("Armenian dram")]
            AMD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ANG", "urn:iso:std:iso:4217"), Description("Netherlands Antillean guilder")]
            ANG,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("AOA", "urn:iso:std:iso:4217"), Description("Angolan kwanza")]
            AOA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ARS", "urn:iso:std:iso:4217"), Description("Argentine peso")]
            ARS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("AUD", "urn:iso:std:iso:4217"), Description("Australian dollar")]
            AUD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("AWG", "urn:iso:std:iso:4217"), Description("Aruban florin")]
            AWG,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("AZN", "urn:iso:std:iso:4217"), Description("Azerbaijani manat")]
            AZN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BAM", "urn:iso:std:iso:4217"), Description("Bosnia and Herzegovina convertible mark")]
            BAM,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BBD", "urn:iso:std:iso:4217"), Description("Barbados dollar")]
            BBD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BDT", "urn:iso:std:iso:4217"), Description("Bangladeshi taka")]
            BDT,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BGN", "urn:iso:std:iso:4217"), Description("Bulgarian lev")]
            BGN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BHD", "urn:iso:std:iso:4217"), Description("Bahraini dinar")]
            BHD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BIF", "urn:iso:std:iso:4217"), Description("Burundian franc")]
            BIF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BMD", "urn:iso:std:iso:4217"), Description("Bermudian dollar")]
            BMD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BND", "urn:iso:std:iso:4217"), Description("Brunei dollar")]
            BND,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BOB", "urn:iso:std:iso:4217"), Description("Boliviano")]
            BOB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BOV", "urn:iso:std:iso:4217"), Description("Bolivian Mvdol (funds code)")]
            BOV,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BRL", "urn:iso:std:iso:4217"), Description("Brazilian real")]
            BRL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BSD", "urn:iso:std:iso:4217"), Description("Bahamian dollar")]
            BSD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BTN", "urn:iso:std:iso:4217"), Description("Bhutanese ngultrum")]
            BTN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BWP", "urn:iso:std:iso:4217"), Description("Botswana pula")]
            BWP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BYN", "urn:iso:std:iso:4217"), Description("Belarusian ruble")]
            BYN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("BZD", "urn:iso:std:iso:4217"), Description("Belize dollar")]
            BZD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CAD", "urn:iso:std:iso:4217"), Description("Canadian dollar")]
            CAD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CDF", "urn:iso:std:iso:4217"), Description("Congolese franc")]
            CDF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CHE", "urn:iso:std:iso:4217"), Description("WIR Euro (complementary currency)")]
            CHE,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CHF", "urn:iso:std:iso:4217"), Description("Swiss franc")]
            CHF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CHW", "urn:iso:std:iso:4217"), Description("WIR Franc (complementary currency)")]
            CHW,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CLF", "urn:iso:std:iso:4217"), Description("Unidad de Fomento (funds code)")]
            CLF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CLP", "urn:iso:std:iso:4217"), Description("Chilean peso")]
            CLP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CNY", "urn:iso:std:iso:4217"), Description("Renminbi (Chinese) yuan[8]")]
            CNY,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("COP", "urn:iso:std:iso:4217"), Description("Colombian peso")]
            COP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("COU", "urn:iso:std:iso:4217"), Description("Unidad de Valor Real (UVR) (funds code)[9]")]
            COU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CRC", "urn:iso:std:iso:4217"), Description("Costa Rican colon")]
            CRC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CUC", "urn:iso:std:iso:4217"), Description("Cuban convertible peso")]
            CUC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CUP", "urn:iso:std:iso:4217"), Description("Cuban peso")]
            CUP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CVE", "urn:iso:std:iso:4217"), Description("Cape Verde escudo")]
            CVE,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("CZK", "urn:iso:std:iso:4217"), Description("Czech koruna")]
            CZK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("DJF", "urn:iso:std:iso:4217"), Description("Djiboutian franc")]
            DJF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("DKK", "urn:iso:std:iso:4217"), Description("Danish krone")]
            DKK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("DOP", "urn:iso:std:iso:4217"), Description("Dominican peso")]
            DOP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("DZD", "urn:iso:std:iso:4217"), Description("Algerian dinar")]
            DZD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("EGP", "urn:iso:std:iso:4217"), Description("Egyptian pound")]
            EGP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ERN", "urn:iso:std:iso:4217"), Description("Eritrean nakfa")]
            ERN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ETB", "urn:iso:std:iso:4217"), Description("Ethiopian birr")]
            ETB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("EUR", "urn:iso:std:iso:4217"), Description("Euro")]
            EUR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("FJD", "urn:iso:std:iso:4217"), Description("Fiji dollar")]
            FJD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("FKP", "urn:iso:std:iso:4217"), Description("Falkland Islands pound")]
            FKP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GBP", "urn:iso:std:iso:4217"), Description("Pound sterling")]
            GBP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GEL", "urn:iso:std:iso:4217"), Description("Georgian lari")]
            GEL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GGP", "urn:iso:std:iso:4217"), Description("Guernsey Pound")]
            GGP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GHS", "urn:iso:std:iso:4217"), Description("Ghanaian cedi")]
            GHS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GIP", "urn:iso:std:iso:4217"), Description("Gibraltar pound")]
            GIP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GMD", "urn:iso:std:iso:4217"), Description("Gambian dalasi")]
            GMD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GNF", "urn:iso:std:iso:4217"), Description("Guinean franc")]
            GNF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GTQ", "urn:iso:std:iso:4217"), Description("Guatemalan quetzal")]
            GTQ,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("GYD", "urn:iso:std:iso:4217"), Description("Guyanese dollar")]
            GYD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("HKD", "urn:iso:std:iso:4217"), Description("Hong Kong dollar")]
            HKD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("HNL", "urn:iso:std:iso:4217"), Description("Honduran lempira")]
            HNL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("HRK", "urn:iso:std:iso:4217"), Description("Croatian kuna")]
            HRK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("HTG", "urn:iso:std:iso:4217"), Description("Haitian gourde")]
            HTG,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("HUF", "urn:iso:std:iso:4217"), Description("Hungarian forint")]
            HUF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("IDR", "urn:iso:std:iso:4217"), Description("Indonesian rupiah")]
            IDR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ILS", "urn:iso:std:iso:4217"), Description("Israeli new shekel")]
            ILS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("IMP", "urn:iso:std:iso:4217"), Description("Isle of Man Pound")]
            IMP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("INR", "urn:iso:std:iso:4217"), Description("Indian rupee")]
            INR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("IQD", "urn:iso:std:iso:4217"), Description("Iraqi dinar")]
            IQD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("IRR", "urn:iso:std:iso:4217"), Description("Iranian rial")]
            IRR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ISK", "urn:iso:std:iso:4217"), Description("Icelandic króna")]
            ISK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("JEP", "urn:iso:std:iso:4217"), Description("Jersey Pound")]
            JEP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("JMD", "urn:iso:std:iso:4217"), Description("Jamaican dollar")]
            JMD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("JOD", "urn:iso:std:iso:4217"), Description("Jordanian dinar")]
            JOD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("JPY", "urn:iso:std:iso:4217"), Description("Japanese yen")]
            JPY,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KES", "urn:iso:std:iso:4217"), Description("Kenyan shilling")]
            KES,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KGS", "urn:iso:std:iso:4217"), Description("Kyrgyzstani som")]
            KGS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KHR", "urn:iso:std:iso:4217"), Description("Cambodian riel")]
            KHR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KMF", "urn:iso:std:iso:4217"), Description("Comoro franc")]
            KMF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KPW", "urn:iso:std:iso:4217"), Description("North Korean won")]
            KPW,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KRW", "urn:iso:std:iso:4217"), Description("South Korean won")]
            KRW,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KWD", "urn:iso:std:iso:4217"), Description("Kuwaiti dinar")]
            KWD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KYD", "urn:iso:std:iso:4217"), Description("Cayman Islands dollar")]
            KYD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("KZT", "urn:iso:std:iso:4217"), Description("Kazakhstani tenge")]
            KZT,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("LAK", "urn:iso:std:iso:4217"), Description("Lao kip")]
            LAK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("LBP", "urn:iso:std:iso:4217"), Description("Lebanese pound")]
            LBP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("LKR", "urn:iso:std:iso:4217"), Description("Sri Lankan rupee")]
            LKR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("LRD", "urn:iso:std:iso:4217"), Description("Liberian dollar")]
            LRD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("LSL", "urn:iso:std:iso:4217"), Description("Lesotho loti")]
            LSL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("LYD", "urn:iso:std:iso:4217"), Description("Libyan dinar")]
            LYD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MAD", "urn:iso:std:iso:4217"), Description("Moroccan dirham")]
            MAD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MDL", "urn:iso:std:iso:4217"), Description("Moldovan leu")]
            MDL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MGA", "urn:iso:std:iso:4217"), Description("Malagasy ariary")]
            MGA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MKD", "urn:iso:std:iso:4217"), Description("Macedonian denar")]
            MKD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MMK", "urn:iso:std:iso:4217"), Description("Myanmar kyat")]
            MMK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MNT", "urn:iso:std:iso:4217"), Description("Mongolian tögrög")]
            MNT,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MOP", "urn:iso:std:iso:4217"), Description("Macanese pataca")]
            MOP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MRU", "urn:iso:std:iso:4217"), Description("Mauritanian ouguiya")]
            MRU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MUR", "urn:iso:std:iso:4217"), Description("Mauritian rupee")]
            MUR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MVR", "urn:iso:std:iso:4217"), Description("Maldivian rufiyaa")]
            MVR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MWK", "urn:iso:std:iso:4217"), Description("Malawian kwacha")]
            MWK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MXN", "urn:iso:std:iso:4217"), Description("Mexican peso")]
            MXN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MXV", "urn:iso:std:iso:4217"), Description("Mexican Unidad de Inversion (UDI) (funds code)")]
            MXV,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MYR", "urn:iso:std:iso:4217"), Description("Malaysian ringgit")]
            MYR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("MZN", "urn:iso:std:iso:4217"), Description("Mozambican metical")]
            MZN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("NAD", "urn:iso:std:iso:4217"), Description("Namibian dollar")]
            NAD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("NGN", "urn:iso:std:iso:4217"), Description("Nigerian naira")]
            NGN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("NIO", "urn:iso:std:iso:4217"), Description("Nicaraguan córdoba")]
            NIO,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("NOK", "urn:iso:std:iso:4217"), Description("Norwegian krone")]
            NOK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("NPR", "urn:iso:std:iso:4217"), Description("Nepalese rupee")]
            NPR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("NZD", "urn:iso:std:iso:4217"), Description("New Zealand dollar")]
            NZD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("OMR", "urn:iso:std:iso:4217"), Description("Omani rial")]
            OMR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("PAB", "urn:iso:std:iso:4217"), Description("Panamanian balboa")]
            PAB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("PEN", "urn:iso:std:iso:4217"), Description("Peruvian Sol")]
            PEN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("PGK", "urn:iso:std:iso:4217"), Description("Papua New Guinean kina")]
            PGK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("PHP", "urn:iso:std:iso:4217"), Description("Philippine piso[13]")]
            PHP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("PKR", "urn:iso:std:iso:4217"), Description("Pakistani rupee")]
            PKR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("PLN", "urn:iso:std:iso:4217"), Description("Polish złoty")]
            PLN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("PYG", "urn:iso:std:iso:4217"), Description("Paraguayan guaraní")]
            PYG,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("QAR", "urn:iso:std:iso:4217"), Description("Qatari riyal")]
            QAR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("RON", "urn:iso:std:iso:4217"), Description("Romanian leu")]
            RON,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("RSD", "urn:iso:std:iso:4217"), Description("Serbian dinar")]
            RSD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("RUB", "urn:iso:std:iso:4217"), Description("Russian ruble")]
            RUB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("RWF", "urn:iso:std:iso:4217"), Description("Rwandan franc")]
            RWF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SAR", "urn:iso:std:iso:4217"), Description("Saudi riyal")]
            SAR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SBD", "urn:iso:std:iso:4217"), Description("Solomon Islands dollar")]
            SBD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SCR", "urn:iso:std:iso:4217"), Description("Seychelles rupee")]
            SCR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SDG", "urn:iso:std:iso:4217"), Description("Sudanese pound")]
            SDG,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SEK", "urn:iso:std:iso:4217"), Description("Swedish krona/kronor")]
            SEK,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SGD", "urn:iso:std:iso:4217"), Description("Singapore dollar")]
            SGD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SHP", "urn:iso:std:iso:4217"), Description("Saint Helena pound")]
            SHP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SLL", "urn:iso:std:iso:4217"), Description("Sierra Leonean leone")]
            SLL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SOS", "urn:iso:std:iso:4217"), Description("Somali shilling")]
            SOS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SRD", "urn:iso:std:iso:4217"), Description("Surinamese dollar")]
            SRD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SSP", "urn:iso:std:iso:4217"), Description("South Sudanese pound")]
            SSP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("STN", "urn:iso:std:iso:4217"), Description("São Tomé and Príncipe dobra")]
            STN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SVC", "urn:iso:std:iso:4217"), Description("Salvadoran colón")]
            SVC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SYP", "urn:iso:std:iso:4217"), Description("Syrian pound")]
            SYP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("SZL", "urn:iso:std:iso:4217"), Description("Swazi lilangeni")]
            SZL,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("THB", "urn:iso:std:iso:4217"), Description("Thai baht")]
            THB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TJS", "urn:iso:std:iso:4217"), Description("Tajikistani somoni")]
            TJS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TMT", "urn:iso:std:iso:4217"), Description("Turkmenistan manat")]
            TMT,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TND", "urn:iso:std:iso:4217"), Description("Tunisian dinar")]
            TND,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TOP", "urn:iso:std:iso:4217"), Description("Tongan paʻanga")]
            TOP,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TRY", "urn:iso:std:iso:4217"), Description("Turkish lira")]
            TRY,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TTD", "urn:iso:std:iso:4217"), Description("Trinidad and Tobago dollar")]
            TTD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TVD", "urn:iso:std:iso:4217"), Description("Tuvalu Dollar")]
            TVD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TWD", "urn:iso:std:iso:4217"), Description("New Taiwan dollar")]
            TWD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("TZS", "urn:iso:std:iso:4217"), Description("Tanzanian shilling")]
            TZS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("UAH", "urn:iso:std:iso:4217"), Description("Ukrainian hryvnia")]
            UAH,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("UGX", "urn:iso:std:iso:4217"), Description("Ugandan shilling")]
            UGX,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("USD", "urn:iso:std:iso:4217"), Description("United States dollar")]
            USD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("USN", "urn:iso:std:iso:4217"), Description("United States dollar (next day) (funds code)")]
            USN,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("UYI", "urn:iso:std:iso:4217"), Description("Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)")]
            UYI,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("UYU", "urn:iso:std:iso:4217"), Description("Uruguayan peso")]
            UYU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("UZS", "urn:iso:std:iso:4217"), Description("Uzbekistan som")]
            UZS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("VEF", "urn:iso:std:iso:4217"), Description("Venezuelan bolívar")]
            VEF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("VND", "urn:iso:std:iso:4217"), Description("Vietnamese đồng")]
            VND,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("VUV", "urn:iso:std:iso:4217"), Description("Vanuatu vatu")]
            VUV,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("WST", "urn:iso:std:iso:4217"), Description("Samoan tala")]
            WST,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XAF", "urn:iso:std:iso:4217"), Description("CFA franc BEAC")]
            XAF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XAG", "urn:iso:std:iso:4217"), Description("Silver (one troy ounce)")]
            XAG,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XAU", "urn:iso:std:iso:4217"), Description("Gold (one troy ounce)")]
            XAU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XBA", "urn:iso:std:iso:4217"), Description("European Composite Unit (EURCO) (bond market unit)")]
            XBA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XBB", "urn:iso:std:iso:4217"), Description("European Monetary Unit (E.M.U.-6) (bond market unit)")]
            XBB,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XBC", "urn:iso:std:iso:4217"), Description("European Unit of Account 9 (E.U.A.-9) (bond market unit)")]
            XBC,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XBD", "urn:iso:std:iso:4217"), Description("European Unit of Account 17 (E.U.A.-17) (bond market unit)")]
            XBD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XCD", "urn:iso:std:iso:4217"), Description("East Caribbean dollar")]
            XCD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XDR", "urn:iso:std:iso:4217"), Description("Special drawing rights")]
            XDR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XOF", "urn:iso:std:iso:4217"), Description("CFA franc BCEAO")]
            XOF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XPD", "urn:iso:std:iso:4217"), Description("Palladium (one troy ounce)")]
            XPD,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XPF", "urn:iso:std:iso:4217"), Description("CFP franc (franc Pacifique)")]
            XPF,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XPT", "urn:iso:std:iso:4217"), Description("Platinum (one troy ounce)")]
            XPT,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XSU", "urn:iso:std:iso:4217"), Description("SUCRE")]
            XSU,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XTS", "urn:iso:std:iso:4217"), Description("Code reserved for testing purposes")]
            XTS,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XUA", "urn:iso:std:iso:4217"), Description("ADB Unit of Account")]
            XUA,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("XXX", "urn:iso:std:iso:4217"), Description("No currency")]
            XXX,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("YER", "urn:iso:std:iso:4217"), Description("Yemeni rial")]
            YER,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ZAR", "urn:iso:std:iso:4217"), Description("South African rand")]
            ZAR,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ZMW", "urn:iso:std:iso:4217"), Description("Zambian kwacha")]
            ZMW,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: urn:iso:std:iso:4217)
            /// </summary>
            [EnumLiteral("ZWL", "urn:iso:std:iso:4217"), Description("Zimbabwean dollar A/10")]
            ZWL,
        }

        /// <summary>
        /// Numerical value (with implicit precision)
        /// </summary>
        [FhirElement("value", InSummary=true, Order=30)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDecimal ValueElement
        {
            get { return _ValueElement; }
            set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDecimal _ValueElement;
        
        /// <summary>
        /// Numerical value (with implicit precision)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public decimal? Value
        {
            get { return ValueElement != null ? ValueElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  ValueElement = null; 
                else
                  ValueElement = new Hl7.Fhir.Model.FhirDecimal(value);
                OnPropertyChanged("Value");
            }
        }
        
        /// <summary>
        /// ISO 4217 Currency Code
        /// </summary>
        [FhirElement("currency", InSummary=true, Order=40)]
        [DataMember]
        public Code<Hl7.Fhir.Model.Money.Currencies> CurrencyElement
        {
            get { return _CurrencyElement; }
            set { _CurrencyElement = value; OnPropertyChanged("CurrencyElement"); }
        }
        
        private Code<Hl7.Fhir.Model.Money.Currencies> _CurrencyElement;
        
        /// <summary>
        /// ISO 4217 Currency Code
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.Money.Currencies? Currency
        {
            get { return CurrencyElement != null ? CurrencyElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  CurrencyElement = null; 
                else
                  CurrencyElement = new Code<Hl7.Fhir.Model.Money.Currencies>(value);
                OnPropertyChanged("Currency");
            }
        }
        

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Money;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirDecimal)ValueElement.DeepCopy();
                if(CurrencyElement != null) dest.CurrencyElement = (Code<Hl7.Fhir.Model.Money.Currencies>)CurrencyElement.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Money());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Money;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
            if( !DeepComparable.Matches(CurrencyElement, otherT.CurrencyElement)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Money;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
            if( !DeepComparable.IsExactly(CurrencyElement, otherT.CurrencyElement)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (ValueElement != null) yield return ValueElement;
                if (CurrencyElement != null) yield return CurrencyElement;
            }
        }

        [NotMapped]
        public override IEnumerable<ElementValue> NamedChildren 
        { 
            get 
            { 
                foreach (var item in base.NamedChildren) yield return item; 
                if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                if (CurrencyElement != null) yield return new ElementValue("currency", CurrencyElement);
 
            } 
        } 
    
    
    }
    
}
