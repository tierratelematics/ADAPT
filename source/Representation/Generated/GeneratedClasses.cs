﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 
namespace AgGateway.ADAPT.Representation.Generated
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes", IsNullable = false)]
   public partial class NodeVersions
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Node")]
      public NodeVersionsNode[] Node;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes")]
   public partial class NodeVersionsNode
   {

      /// <remarks/>
      public NodeVersionsNodeChangeException ChangeException;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string uuid;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public System.DateTime lastSeen;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes")]
   public partial class NodeVersionsNodeChangeException
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string erid;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes", IsNullable = false)]
   public partial class Synchronization
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("Node", IsNullable = false)]
      public NodeVersionsNode[] NodeVersions;

      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("Entity", IsNullable = false)]
      public string[] EntityDeletions;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:BasicTypes", IsNullable = false)]
   public partial class EntityDeletions
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Entity")]
      public string[] Entity;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:Representation", IsNullable = false)]
   public partial class RepresentationSystem
   {

      /// <remarks/>
      public RepresentationSystemSchemaVersion SchemaVersion;

      /// <remarks/>
      public RepresentationSystemContentVersion ContentVersion;

      /// <remarks/>
      public RepresentationSystemRepresentations Representations;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemSchemaVersion
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int major;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int minor;

      public RepresentationSystemSchemaVersion()
      {
         this.major = 1;
         this.minor = 1;
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemContentVersion
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int major;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int minor;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentations
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("NumericRepresentation")]
      public RepresentationSystemRepresentationsNumericRepresentation[] NumericRepresentation;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("EnumeratedRepresentation")]
      public RepresentationSystemRepresentationsEnumeratedRepresentation[] EnumeratedRepresentation;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsNumericRepresentation
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasureDefault", typeof(RepresentationSystemRepresentationsNumericRepresentationUnitOfMeasureDefault))]
      [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasurePreference", typeof(RepresentationSystemRepresentationsNumericRepresentationUnitOfMeasurePreference))]
      public UnitOfMeasurePreferenceType[] Items;

      /// <remarks/>
      public RepresentationSystemRepresentationsNumericRepresentationUnitDimensionRef UnitDimensionRef;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Name")]
      public RepresentationSystemRepresentationsNumericRepresentationName[] Name;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("RelatedDDI")]
      public RepresentationSystemRepresentationsNumericRepresentationRelatedDDI[] RelatedDDI;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public long domainTag;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public short digits;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public short @decimal;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsNumericRepresentationUnitOfMeasureDefault : UnitOfMeasurePreferenceType
   {
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class UnitOfMeasurePreferenceType
   {

      /// <remarks/>
      public UnitOfMeasurePreferenceTypePresentationRange PresentationRange;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unitOfMeasure;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public short digits;

      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool digitsSpecified;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unitOfMeasureSystem;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double minValue;

      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool minValueSpecified;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double maxValue;

      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool maxValueSpecified;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public short @decimal;

      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool decimalSpecified;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class UnitOfMeasurePreferenceTypePresentationRange
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double minValue;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double maxValue;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsNumericRepresentationUnitOfMeasurePreference : UnitOfMeasurePreferenceType
   {
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsNumericRepresentationUnitDimensionRef
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unitDimension;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsNumericRepresentationName
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string locale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string description;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string prefix;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string postfix;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string alternateLabel;

      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsNumericRepresentationRelatedDDI
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int ddi;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unitOfMeasure;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(1D)]
      public double resolution;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(0D)]
      public double offset;

      public RepresentationSystemRepresentationsNumericRepresentationRelatedDDI()
      {
         this.resolution = 1D;
         this.offset = 0D;
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsEnumeratedRepresentation
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Name")]
      public RepresentationSystemRepresentationsEnumeratedRepresentationName[] Name;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("EnumeratedMember", typeof(RepresentationSystemRepresentationsEnumeratedRepresentationEnumeratedMember))]
      [System.Xml.Serialization.XmlElementAttribute("EnumeratedRepresentationRef", typeof(RepresentationSystemRepresentationsEnumeratedRepresentationEnumeratedRepresentationRef))]
      public object[] Items;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("RelatedDDI")]
      public RepresentationSystemRepresentationsEnumeratedRepresentationRelatedDDI[] RelatedDDI;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public long domainTag;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsEnumeratedRepresentationName
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string locale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string description;

      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsEnumeratedRepresentationEnumeratedMember
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Name")]
      public RepresentationSystemRepresentationsEnumeratedRepresentationEnumeratedMemberName[] Name;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public long domainTag;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int refID;

      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool refIDSpecified;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsEnumeratedRepresentationEnumeratedMemberName
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string locale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string description;

      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsEnumeratedRepresentationEnumeratedRepresentationRef
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string EnumeratedRepresentationID;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class RepresentationSystemRepresentationsEnumeratedRepresentationRelatedDDI
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int ddi;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:Representation", IsNullable = false)]
   public partial class Number
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double value;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int sourceUOM;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   [System.Xml.Serialization.XmlRootAttribute("NumericRepresentationValue", Namespace = "urn:schemas-adapt-aggateway-org:Representation", IsNullable = false)]
   public partial class NumericRepresentationValueType
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double value;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string sourceUOM;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string NumericRepresentation;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:Representation", IsNullable = false)]
   public partial class NumericRepresentation : NumericRepresentationType
   {
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   public partial class NumericRepresentationType
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string sourceUOM;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string NumericRepresentation;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   [System.Xml.Serialization.XmlRootAttribute("EnumeratedRepresentationValue", Namespace = "urn:schemas-adapt-aggateway-org:Representation", IsNullable = false)]
   public partial class EnumeratedRepresentationValue1
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string value;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string EnumeratedRepresentation;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:Representation")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:Representation", IsNullable = false)]
   public partial class EnumeratedRepresentation
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute("EnumeratedRepresentation")]
      public string EnumeratedRepresentation1;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem", IsNullable = false)]
   public partial class UnitSystem
   {

      /// <remarks/>
      public UnitSystemSchemaVersion SchemaVersion;

      /// <remarks/>
      public UnitSystemContentVersion ContentVersion;

      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("Language", IsNullable = false)]
      public string[] SupportedLanguages;

      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("UnitDimension", IsNullable = false)]
      public UnitSystemUnitDimension[] UnitDimensions;

      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("UnitOfMeasureSystem", IsNullable = false)]
      public UnitSystemUnitOfMeasureSystem[] UnitOfMeasureSystems;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemSchemaVersion
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int major;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int minor;

      public UnitSystemSchemaVersion()
      {
         this.major = 1;
         this.minor = 1;
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemContentVersion
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int major;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int minor;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitDimension
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CompositeUnitDimensionRepresentation", typeof(UnitSystemUnitDimensionCompositeUnitDimensionRepresentation))]
      [System.Xml.Serialization.XmlElementAttribute("UnitDimensionRepresentation", typeof(UnitSystemUnitDimensionUnitDimensionRepresentation))]
      public object[] Items;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Name")]
      public UnitSystemUnitDimensionName[] Name;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitDimensionCompositeUnitDimensionRepresentation
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("UnitDimensionRef")]
      public UnitSystemUnitDimensionCompositeUnitDimensionRepresentationUnitDimensionRef[] UnitDimensionRef;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double scale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double baseOffset;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitDimensionCompositeUnitDimensionRepresentationUnitDimensionRef
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string UnitDimensionRef;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(1D)]
      public double power;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string display;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string baseUnitOfMeasureRef;

      public UnitSystemUnitDimensionCompositeUnitDimensionRepresentationUnitDimensionRef()
      {
         this.power = 1D;
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitDimensionUnitDimensionRepresentation
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure")]
      public UnitSystemUnitDimensionUnitDimensionRepresentationUnitOfMeasure[] UnitOfMeasure;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitDimensionUnitDimensionRepresentationUnitOfMeasure
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Name")]
      public UnitSystemUnitDimensionUnitDimensionRepresentationUnitOfMeasureName[] Name;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double scale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double baseOffset;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public short uomID;

      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool uomIDSpecified;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitDimensionUnitDimensionRepresentationUnitOfMeasureName
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string locale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string label;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string plural;

      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitDimensionName
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string locale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string description;

      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitOfMeasureSystem
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Name")]
      public UnitSystemUnitOfMeasureSystemName[] Name;

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasureRef")]
      public UnitSystemUnitOfMeasureSystemUnitOfMeasureRef[] UnitOfMeasureRef;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string domainID;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitOfMeasureSystemName
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string locale;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string label;

      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value;
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-adapt-aggateway-org:UnitSystem")]
   public partial class UnitSystemUnitOfMeasureSystemUnitOfMeasureRef
   {

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unitOfMeasureRef;
   }
}
