using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot(ElementName = "sanctionsData", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
public class SanctionsData
{
    [XmlElement(ElementName = "publicationInfo", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public PublicationInfo PublicationInfo { get; set; }

    [XmlElement(ElementName = "referenceValues", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public ReferenceValues ReferenceValues { get; set; }

    [XmlElement(ElementName = "featureTypes", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public FeatureTypes FeatureTypes { get; set; }

    [XmlArray(ElementName = "entities", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "entity", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<Entity> Entities { get; set; }
}

public class PublicationInfo
{
    [XmlElement(ElementName = "dataAsOf", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime DataAsOf { get; set; }

    [XmlElement(ElementName = "filters", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public Filters Filters { get; set; }
}

public class Filters
{
    [XmlElement(ElementName = "sanctionsLists", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public SanctionsLists SanctionsLists { get; set; }
}

public class SanctionsLists
{
    [XmlElement(ElementName = "sanctionsList", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
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
    [XmlElement(ElementName = "referenceValue", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<ReferenceValue> ReferenceValueList { get; set; }
}

public class ReferenceValue
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlElement(ElementName = "type", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Type { get; set; }

    [XmlElement(ElementName = "value", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Value { get; set; }
}

public class FeatureTypes
{
    [XmlElement(ElementName = "featureType", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<FeatureType> FeatureTypeList { get; set; }
}

public class FeatureType
{
    [XmlAttribute("featureTypeId")]
    public int FeatureTypeId { get; set; }

    [XmlElement(ElementName = "type", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Type { get; set; }

    [XmlElement(ElementName = "detailType", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DetailType DetailType { get; set; }

    [XmlElement(ElementName = "publishExclude", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool PublishExclude { get; set; }
}

public class DetailType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class Entity
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "generalInfo", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public GeneralInfo GeneralInfo { get; set; }

    [XmlArray(ElementName = "sanctionsLists", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "sanctionsList", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<SanctionsList> SanctionsLists { get; set; }

    [XmlArray(ElementName = "sanctionsPrograms", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "sanctionsProgram", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<SanctionsProgram> SanctionsPrograms { get; set; }

    [XmlArray(ElementName = "sanctionsTypes", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "sanctionsType", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<SanctionsType> SanctionsTypes { get; set; }

    [XmlArray(ElementName = "legalAuthorities", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "legalAuthority", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<LegalAuthority> LegalAuthorities { get; set; }

    [XmlArray(ElementName = "names", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "name", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<Name> Names { get; set; }

    [XmlArray(ElementName = "addresses", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "address", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<Address> Addresses { get; set; }

    [XmlArray(ElementName = "features", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "feature", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<Feature> Features { get; set; }

    [XmlArray(ElementName = "identityDocuments", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "identityDocument", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<IdentityDocument> IdentityDocuments { get; set; }

    [XmlArray(ElementName = "relationships", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "relationship", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<Relationship> Relationships { get; set; }
}

public class GeneralInfo
{
    [XmlElement(ElementName = "identityId", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public int IdentityId { get; set; }

    [XmlElement(ElementName = "entityType", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public EntityType EntityType { get; set; }
}

public class EntityType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class SanctionsProgram
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlText]
    public string ProgramName { get; set; }
}

public class SanctionsType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}

public class LegalAuthority
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlText]
    public string AuthorityName { get; set; }
}

public class Name
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "isPrimary", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsPrimary { get; set; }

    [XmlElement(ElementName = "isLowQuality", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsLowQuality { get; set; }

    [XmlArray(ElementName = "translations", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "translation", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<Translation> Translations { get; set; }
}

public class Translation
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "isPrimary", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsPrimary { get; set; }

    [XmlElement(ElementName = "script", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public Script Script { get; set; }

    [XmlElement(ElementName = "formattedFirstName", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string FormattedFirstName { get; set; }

    [XmlElement(ElementName = "formattedLastName", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string FormattedLastName { get; set; }

    [XmlElement(ElementName = "formattedFullName", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string FormattedFullName { get; set; }

    [XmlArray(ElementName = "nameParts", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "namePart", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
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

    [XmlElement(ElementName = "type", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public NamePartType Type { get; set; }

    [XmlElement(ElementName = "value", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
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

    [XmlElement(ElementName = "country", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public Country Country { get; set; }

    [XmlArray(ElementName = "translations", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "translation", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<AddressTranslation> Translations { get; set; }
}

public class AddressTranslation
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "isPrimary", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsPrimary { get; set; }

    [XmlElement(ElementName = "script", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public Script Script { get; set; }

    [XmlArray(ElementName = "addressParts", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    [XmlArrayItem(ElementName = "addressPart", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public List<AddressPart> AddressParts { get; set; }
}

public class AddressPart
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "type", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public AddressPartType Type { get; set; }

    [XmlElement(ElementName = "value", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Value { get; set; }
}

public class AddressPartType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
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

    [XmlElement(ElementName = "type", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public FeatureType Type { get; set; }

    [XmlElement(ElementName = "versionId", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public int VersionId { get; set; }

    [XmlElement(ElementName = "value", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Value { get; set; }

    [XmlElement(ElementName = "isPrimary", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsPrimary { get; set; }

    [XmlElement(ElementName = "reliability", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public Reliability Reliability { get; set; }
}

public class Reliability
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string ReliabilityName { get; set; }
}

public class IdentityDocument
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "type", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public IdentityDocumentType Type { get; set; }

    [XmlElement(ElementName = "name", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Name { get; set; }

    [XmlElement(ElementName = "number", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Number { get; set; }

    [XmlElement(ElementName = "issueDate", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public IssueDate IssueDate { get; set; }

    [XmlElement(ElementName = "expirationDate", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public ExpirationDate ExpirationDate { get; set; }
}

public class IssueDate
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "fromDateBegin", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime FromDateBegin { get; set; }

    [XmlElement(ElementName = "fromDateEnd", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime FromDateEnd { get; set; }

    [XmlElement(ElementName = "toDateBegin", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime ToDateBegin { get; set; }

    [XmlElement(ElementName = "toDateEnd", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime ToDateEnd { get; set; }

    [XmlElement(ElementName = "isApproximate", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsApproximate { get; set; }

    [XmlElement(ElementName = "isDateRange", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsDateRange { get; set; }
}

public class ExpirationDate
{
    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement(ElementName = "fromDateBegin", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime FromDateBegin { get; set; }

    [XmlElement(ElementName = "fromDateEnd", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime FromDateEnd { get; set; }

    [XmlElement(ElementName = "toDateBegin", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime ToDateBegin { get; set; }

    [XmlElement(ElementName = "toDateEnd", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public DateTime ToDateEnd { get; set; }

    [XmlElement(ElementName = "isApproximate", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsApproximate { get; set; }

    [XmlElement(ElementName = "isDateRange", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public bool IsDateRange { get; set; }
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

    [XmlElement(ElementName = "type", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public RelationshipType Type { get; set; }

    [XmlElement(ElementName = "description", Namespace = "https://sanctionslistservice.ofac.treas.gov/api/PublicationPreview/exports/ENHANCED_XML")]
    public string Description { get; set; }
}

public class RelationshipType
{
    [XmlAttribute("refId")]
    public int RefId { get; set; }

    [XmlText]
    public string TypeName { get; set; }
}
