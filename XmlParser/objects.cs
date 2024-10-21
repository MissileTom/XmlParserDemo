namespace XmlParser;

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot(ElementName = "sanctionsData", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
public class SanctionsData
{
    [XmlElement(ElementName = "publicationInfo")]
    public PublicationInfo PublicationInfo { get; set; }

    [XmlElement(ElementName = "referenceValues")]
    public ReferenceValues ReferenceValues { get; set; }

    [XmlElement(ElementName = "featureTypes")]
    public FeatureTypes FeatureTypes { get; set; }

    [XmlElement(ElementName = "entities")]
    public Entities Entities { get; set; }
}

public class PublicationInfo
{
    [XmlElement(ElementName = "dataAsOf")]
    public DateTime DataAsOf { get; set; }

    [XmlElement(ElementName = "filters")]
    public Filters Filters { get; set; }
}

public class Filters
{
    [XmlElement(ElementName = "sanctionsLists")]
    public SanctionsLists SanctionsLists { get; set; }
}

public class SanctionsLists
{
    [XmlElement(ElementName = "sanctionsList")]
    public List<SanctionsList> SanctionsList { get; set; }
}

public class SanctionsList
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string ListName { get; set; }
}

public class ReferenceValues
{
    [XmlElement(ElementName = "referenceValue")]
    public List<ReferenceValue> ReferenceValueList { get; set; }
}

public class ReferenceValue
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlElement(ElementName = "type")]
    public string Type { get; set; }

    [XmlElement(ElementName = "value")]
    public string Value { get; set; }
}

public class FeatureTypes
{
    [XmlElement(ElementName = "featureType")]
    public List<FeatureType> FeatureTypeList { get; set; }
}

public class FeatureType
{
    [XmlAttribute("featureTypeId")]
    public int FeatureTypeId { get; set; }

    [XmlElement(ElementName = "type")]
    public string Type { get; set; }

    [XmlElement(ElementName = "detailType")]
    public DetailType DetailType { get; set; }

    [XmlElement(ElementName = "publishExclude")]
    public bool PublishExclude { get; set; }
}

public class DetailType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class Entities
{
    [XmlElement(ElementName = "entity")]
    public List<Entity> EntityList { get; set; }
}

public class Entity
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "generalInfo")]
    public GeneralInfo GeneralInfo { get; set; }

    [XmlElement(ElementName = "sanctionsLists")]
    public List<SanctionsList> SanctionsLists { get; set; }

    [XmlElement(ElementName = "sanctionsPrograms")]
    public List<SanctionsProgram> SanctionsPrograms { get; set; }

    [XmlElement(ElementName = "sanctionsTypes")]
    public List<SanctionsType> SanctionsTypes { get; set; }

    [XmlElement(ElementName = "legalAuthorities")]
    public List<LegalAuthority> LegalAuthorities { get; set; }

    [XmlElement(ElementName = "names")]
    public List<Name> Names { get; set; }

    [XmlElement(ElementName = "addresses")]
    public List<Address> Addresses { get; set; }

    [XmlElement(ElementName = "features")]
    public List<Feature> Features { get; set; }

    [XmlElement(ElementName = "identityDocuments")]
    public List<IdentityDocument> IdentityDocuments { get; set; }

    [XmlElement(ElementName = "relationships")]
    public List<Relationship> Relationships { get; set; }
}

public class GeneralInfo
{
    [XmlElement(ElementName = "identityId")]
    public int IdentityId { get; set; }

    [XmlElement(ElementName = "entityType")]
    public EntityType EntityType { get; set; }
}

public class EntityType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string Type { get; set; }
}

public class SanctionsProgram
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlText]
    public string Program { get; set; }
}

public class SanctionsType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlText]
    public string Type { get; set; }
}

public class LegalAuthority
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlText]
    public string Authority { get; set; }
}

public class Name
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "isPrimary")]
    public bool IsPrimary { get; set; }

    [XmlElement(ElementName = "isLowQuality")]
    public bool IsLowQuality { get; set; }

    [XmlElement(ElementName = "translations")]
    public List<Translation> Translations { get; set; }
}

public class Translation
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "isPrimary")]
    public bool IsPrimary { get; set; }

    [XmlElement(ElementName = "script")]
    public Script Script { get; set; }

    [XmlElement(ElementName = "formattedFirstName")]
    public string FormattedFirstName { get; set; }

    [XmlElement(ElementName = "formattedLastName")]
    public string FormattedLastName { get; set; }

    [XmlElement(ElementName = "formattedFullName")]
    public string FormattedFullName { get; set; }

    [XmlElement(ElementName = "nameParts")]
    public List<NamePart> NameParts { get; set; }
}

public class Script
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string ScriptName { get; set; }
}

public class NamePart
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "type")]
    public NamePartType Type { get; set; }

    [XmlElement(ElementName = "value")]
    public string Value { get; set; }
}

public class NamePartType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class Address
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "country")]
    public Country Country { get; set; }

    [XmlElement(ElementName = "translations")]
    public List<Translation> Translations { get; set; }
}

public class Country
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string CountryName { get; set; }
}

public class Feature
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "type")]
    public FeatureTypeDetail Type { get; set; }

    [XmlElement(ElementName = "value")]
    public string Value { get; set; }

    [XmlElement(ElementName = "isPrimary")]
    public bool IsPrimary { get; set; }

    [XmlElement(ElementName = "reliability")]
    public Reliability Reliability { get; set; }
}

public class FeatureTypeDetail
{
    [XmlAttribute("featureTypeId")]
    public int FeatureTypeId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class Reliability
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string ReliabilityValue { get; set; }
}

public class IdentityDocument
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "type")]
    public IdentityDocumentType Type { get; set; }

    [XmlElement(ElementName = "name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "documentNumber")]
    public string DocumentNumber { get; set; }

    [XmlElement(ElementName = "isValid")]
    public bool IsValid { get; set; }

    [XmlElement(ElementName = "issuingCountry")]
    public Country IssuingCountry { get; set; }
}

public class IdentityDocumentType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class Relationship
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "type")]
    public RelationshipType Type { get; set; }

    [XmlElement(ElementName = "relatedEntity")]
    public RelatedEntity RelatedEntity { get; set; }
}

public class RelationshipType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class RelatedEntity
{
    [XmlAttribute("entityId")]
    public int EntityId { get; set; }

    [XmlText]
    public string EntityName { get; set; }
}
