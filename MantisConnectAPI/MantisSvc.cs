﻿namespace MantisConnectAPI
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://futureware.biz/mantisconnect", ConfigurationName = "MantisConnectPortType")]
    public interface MantisConnectPortType
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_version", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string mc_version();

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_version", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string> mc_versionAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_login", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        UserData mc_login(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_login", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<UserData> mc_loginAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_status", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_status(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_status", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_statusAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_priorities", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_priorities(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_priorities", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_prioritiesAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_severities", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_severities(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_severities", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_severitiesAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_reproducibilities", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_reproducibilities(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_reproducibilities", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_reproducibilitiesAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_projections", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_projections(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_projections", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_projectionsAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_etas", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_etas(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_etas", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_etasAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_resolutions", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_resolutions(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_resolutions", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_resolutionsAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_access_levels", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_access_levels(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_access_levels", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_access_levelsAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_project_status", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_project_status(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_project_status", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_project_statusAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_project_view_states", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_project_view_states(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_project_view_states", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_project_view_statesAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_view_states", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_view_states(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_view_states", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_view_statesAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_custom_field_types", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ObjectRef[] mc_enum_custom_field_types(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_custom_field_types", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ObjectRef[]> mc_enum_custom_field_typesAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_get", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string mc_enum_get(string username, string password, string enumeration);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_enum_get", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string> mc_enum_getAsync(string username, string password, string enumeration);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_exists", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_exists(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_exists", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_existsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueData mc_issue_get(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueData> mc_issue_getAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issues_get", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueData[] mc_issues_get(string username, string password, string[] issue_ids);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issues_get", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueData[]> mc_issues_getAsync(string username, string password, string[] issue_ids);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issues_get_header", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueHeaderData[] mc_issues_get_header(string username, string password, string[] issue_ids);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issues_get_header", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueHeaderData[]> mc_issues_get_headerAsync(string username, string password, string[] issue_ids);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get_history", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        HistoryData[] mc_issue_get_history(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get_history", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<HistoryData[]> mc_issue_get_historyAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get_biggest_id", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_issue_get_biggest_id(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get_biggest_id", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_issue_get_biggest_idAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get_id_from_summary", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_issue_get_id_from_summary(string username, string password, string summary);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_get_id_from_summary", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_issue_get_id_from_summaryAsync(string username, string password, string summary);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_issue_add(string username, string password, IssueData issue);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_issue_addAsync(string username, string password, IssueData issue);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_update", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_update(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issueId, IssueData issue);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_update", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_updateAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issueId, IssueData issue);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_set_tags", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_set_tags(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, TagData[] tags);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_set_tags", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_set_tagsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, TagData[] tags);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_note_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_issue_note_add(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, IssueNoteData note);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_note_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_issue_note_addAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, IssueNoteData note);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_note_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_note_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_note_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_note_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_note_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_note_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_note_update", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_note_update(string username, string password, IssueNoteData note);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_note_update", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_note_updateAsync(string username, string password, IssueNoteData note);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_relationship_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_issue_relationship_add(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, RelationshipData relationship);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_relationship_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_issue_relationship_addAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, RelationshipData relationship);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_relationship_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_relationship_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string relationship_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_relationship_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_relationship_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string relationship_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_attachment_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_issue_attachment_add(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, string name, string file_type, [System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")] byte[] content);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_attachment_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_issue_attachment_addAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, string name, string file_type, [System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")] byte[] content);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_attachment_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_attachment_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_attachment_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_attachment_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_attachment_get", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")]
        byte[] mc_issue_attachment_get(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_attachment_get", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")]
        System.Threading.Tasks.Task<byte[]> mc_issue_attachment_getAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_project_add(string username, string password, ProjectData project);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_project_addAsync(string username, string password, ProjectData project);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_project_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_project_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_update", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_project_update(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, ProjectData project);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_update", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_project_updateAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, ProjectData project);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_id_from_name", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_project_get_id_from_name(string username, string password, string project_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_id_from_name", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_project_get_id_from_nameAsync(string username, string password, string project_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_issues_for_user", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueData[] mc_project_get_issues_for_user(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string filter_type, AccountData target_user, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_issues_for_user", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueData[]> mc_project_get_issues_for_userAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string filter_type, AccountData target_user, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_issues", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueData[] mc_project_get_issues(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_issues", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueData[]> mc_project_get_issuesAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_issue_headers", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueHeaderData[] mc_project_get_issue_headers(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_issue_headers", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueHeaderData[]> mc_project_get_issue_headersAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_users", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        AccountData[] mc_project_get_users(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string access);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_users", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<AccountData[]> mc_project_get_usersAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string access);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_projects_get_user_accessible", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ProjectData[] mc_projects_get_user_accessible(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_projects_get_user_accessible", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ProjectData[]> mc_projects_get_user_accessibleAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_categories", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string[] mc_project_get_categories(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_categories", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string[]> mc_project_get_categoriesAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_add_category", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_project_add_category(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string p_category_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_add_category", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_project_add_categoryAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string p_category_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_delete_category", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_project_delete_category(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string p_category_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_delete_category", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_project_delete_categoryAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string p_category_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_rename_category_by_na" +
            "me", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_project_rename_category_by_name(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string p_category_name, string p_category_name_new, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string p_assigned_to);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_rename_category_by_na" +
            "me", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_project_rename_category_by_nameAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string p_category_name, string p_category_name_new, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string p_assigned_to);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_versions", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ProjectVersionData[] mc_project_get_versions(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_versions", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ProjectVersionData[]> mc_project_get_versionsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_version_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_project_version_add(string username, string password, ProjectVersionData version);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_version_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_project_version_addAsync(string username, string password, ProjectVersionData version);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_version_update", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_project_version_update(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string version_id, ProjectVersionData version);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_version_update", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_project_version_updateAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string version_id, ProjectVersionData version);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_version_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_project_version_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string version_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_version_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_project_version_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string version_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_released_versions" +
            "", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ProjectVersionData[] mc_project_get_released_versions(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_released_versions" +
            "", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ProjectVersionData[]> mc_project_get_released_versionsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_unreleased_versio" +
            "ns", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ProjectVersionData[] mc_project_get_unreleased_versions(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_unreleased_versio" +
            "ns", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ProjectVersionData[]> mc_project_get_unreleased_versionsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_attachments", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ProjectAttachmentData[] mc_project_get_attachments(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_attachments", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ProjectAttachmentData[]> mc_project_get_attachmentsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_custom_fields", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        CustomFieldDefinitionData[] mc_project_get_custom_fields(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_custom_fields", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<CustomFieldDefinitionData[]> mc_project_get_custom_fieldsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_attachment_get", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")]
        byte[] mc_project_attachment_get(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_attachment_get", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")]
        System.Threading.Tasks.Task<byte[]> mc_project_attachment_getAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_attachment_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_project_attachment_add(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string name, string title, string description, string file_type, [System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")] byte[] content);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_attachment_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_project_attachment_addAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string name, string title, string description, string file_type, [System.Xml.Serialization.SoapElementAttribute(DataType = "base64Binary")] byte[] content);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_attachment_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_project_attachment_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_attachment_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_project_attachment_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_attachment_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_all_subprojects", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string[] mc_project_get_all_subprojects(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_project_get_all_subprojects", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string[]> mc_project_get_all_subprojectsAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_get", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        FilterData[] mc_filter_get(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_get", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<FilterData[]> mc_filter_getAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_get_issues", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueData[] mc_filter_get_issues(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string filter_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_get_issues", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueData[]> mc_filter_get_issuesAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string filter_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_get_issue_headers", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueHeaderData[] mc_filter_get_issue_headers(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string filter_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_get_issue_headers", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueHeaderData[]> mc_filter_get_issue_headersAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string filter_id, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_search_issue_headers", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueHeaderData[] mc_filter_search_issue_headers(string username, string password, FilterSearchData filter, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_search_issue_headers", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueHeaderData[]> mc_filter_search_issue_headersAsync(string username, string password, FilterSearchData filter, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_search_issues", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        IssueData[] mc_filter_search_issues(string username, string password, FilterSearchData filter, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_search_issues", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<IssueData[]> mc_filter_search_issuesAsync(string username, string password, FilterSearchData filter, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_search_issue_ids", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string[] mc_filter_search_issue_ids(string username, string password, FilterSearchData filter, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_filter_search_issue_ids", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string[]> mc_filter_search_issue_idsAsync(string username, string password, FilterSearchData filter, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_config_get_string", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string mc_config_get_string(string username, string password, string config_var);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_config_get_string", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string> mc_config_get_stringAsync(string username, string password, string config_var);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_checkin", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_issue_checkin(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, string comment, bool @fixed);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_issue_checkin", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_issue_checkinAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string issue_id, string comment, bool @fixed);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_user_pref_get_pref", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        string mc_user_pref_get_pref(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string pref_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_user_pref_get_pref", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<string> mc_user_pref_get_prefAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string project_id, string pref_name);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_user_profiles_get_all", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        ProfileDataSearchResult mc_user_profiles_get_all(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_user_profiles_get_all", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<ProfileDataSearchResult> mc_user_profiles_get_allAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_tag_get_all", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        TagDataSearchResult mc_tag_get_all(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_tag_get_all", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<TagDataSearchResult> mc_tag_get_allAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string page_number, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string per_page);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_tag_add", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        string mc_tag_add(string username, string password, TagData tag);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_tag_add", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        System.Threading.Tasks.Task<string> mc_tag_addAsync(string username, string password, TagData tag);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_tag_delete", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProfileData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterCustomField))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldDefinitionData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProjectAttachmentData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HistoryData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(IssueHeaderData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CustomFieldValueForIssueData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AttachmentData))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        bool mc_tag_delete(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string tag_id);

        [System.ServiceModel.OperationContractAttribute(Action = "http://support.fwa.eu/api/soap/mantisconnect.php/mc_tag_delete", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "return")]
        System.Threading.Tasks.Task<bool> mc_tag_deleteAsync(string username, string password, [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")] string tag_id);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class UserData
    {

        private AccountData account_dataField;

        private string access_levelField;

        private string timezoneField;

        /// <remarks/>
        public AccountData account_data
        {
            get
            {
                return this.account_dataField;
            }
            set
            {
                this.account_dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string access_level
        {
            get
            {
                return this.access_levelField;
            }
            set
            {
                this.access_levelField = value;
            }
        }

        /// <remarks/>
        public string timezone
        {
            get
            {
                return this.timezoneField;
            }
            set
            {
                this.timezoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class AccountData
    {

        private string idField;

        private string nameField;

        private string real_nameField;

        private string emailField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string real_name
        {
            get
            {
                return this.real_nameField;
            }
            set
            {
                this.real_nameField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class TagDataSearchResult
    {

        private TagData[] resultsField;

        private string total_resultsField;

        /// <remarks/>
        public TagData[] results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string total_results
        {
            get
            {
                return this.total_resultsField;
            }
            set
            {
                this.total_resultsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class TagData
    {

        private string idField;

        private AccountData user_idField;

        private string nameField;

        private string descriptionField;

        private System.DateTime date_createdField;

        private bool date_createdFieldSpecified;

        private System.DateTime date_updatedField;

        private bool date_updatedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public AccountData user_id
        {
            get
            {
                return this.user_idField;
            }
            set
            {
                this.user_idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime date_created
        {
            get
            {
                return this.date_createdField;
            }
            set
            {
                this.date_createdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool date_createdSpecified
        {
            get
            {
                return this.date_createdFieldSpecified;
            }
            set
            {
                this.date_createdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime date_updated
        {
            get
            {
                return this.date_updatedField;
            }
            set
            {
                this.date_updatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool date_updatedSpecified
        {
            get
            {
                return this.date_updatedFieldSpecified;
            }
            set
            {
                this.date_updatedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class ProfileData
    {

        private string idField;

        private AccountData user_idField;

        private string platformField;

        private string osField;

        private string os_buildField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public AccountData user_id
        {
            get
            {
                return this.user_idField;
            }
            set
            {
                this.user_idField = value;
            }
        }

        /// <remarks/>
        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        public string os
        {
            get
            {
                return this.osField;
            }
            set
            {
                this.osField = value;
            }
        }

        /// <remarks/>
        public string os_build
        {
            get
            {
                return this.os_buildField;
            }
            set
            {
                this.os_buildField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        public override string ToString()
        {
            return string.Format("id : {0}, description : {1}, Os : {2}, User name : {3} ", id, description, os, user_id != null ? user_id.real_name : "");
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class ProfileDataSearchResult
    {

        private ProfileData[] resultsField;

        private string total_resultsField;

        /// <remarks/>
        public ProfileData[] results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string total_results
        {
            get
            {
                return this.total_resultsField;
            }
            set
            {
                this.total_resultsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class FilterCustomField
    {

        private ObjectRef fieldField;

        private string[] valueField;

        /// <remarks/>
        public ObjectRef field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        public string[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class ObjectRef
    {

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class FilterSearchData
    {

        private string[] project_idField;

        private string searchField;

        private string[] categoryField;

        private string[] severity_idField;

        private string[] status_idField;

        private string[] priority_idField;

        private string[] reporter_idField;

        private string[] handler_idField;

        private string[] note_user_idField;

        private string[] resolution_idField;

        private string[] product_versionField;

        private string[] user_monitor_idField;

        private string[] hide_status_idField;

        private string sortField;

        private string sort_directionField;

        private bool stickyField;

        private bool stickyFieldSpecified;

        private string[] view_state_idField;

        private string[] fixed_in_versionField;

        private string[] target_versionField;

        private string[] platformField;

        private string[] osField;

        private string[] os_buildField;

        private string start_dayField;

        private string start_monthField;

        private string start_yearField;

        private string end_dayField;

        private string end_monthField;

        private string end_yearField;

        private string[] tag_stringField;

        private string[] tag_selectField;

        private FilterCustomField[] custom_fieldsField;

        /// <remarks/>
        public string[] project_id
        {
            get
            {
                return this.project_idField;
            }
            set
            {
                this.project_idField = value;
            }
        }

        /// <remarks/>
        public string search
        {
            get
            {
                return this.searchField;
            }
            set
            {
                this.searchField = value;
            }
        }

        /// <remarks/>
        public string[] category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public string[] severity_id
        {
            get
            {
                return this.severity_idField;
            }
            set
            {
                this.severity_idField = value;
            }
        }

        /// <remarks/>
        public string[] status_id
        {
            get
            {
                return this.status_idField;
            }
            set
            {
                this.status_idField = value;
            }
        }

        /// <remarks/>
        public string[] priority_id
        {
            get
            {
                return this.priority_idField;
            }
            set
            {
                this.priority_idField = value;
            }
        }

        /// <remarks/>
        public string[] reporter_id
        {
            get
            {
                return this.reporter_idField;
            }
            set
            {
                this.reporter_idField = value;
            }
        }

        /// <remarks/>
        public string[] handler_id
        {
            get
            {
                return this.handler_idField;
            }
            set
            {
                this.handler_idField = value;
            }
        }

        /// <remarks/>
        public string[] note_user_id
        {
            get
            {
                return this.note_user_idField;
            }
            set
            {
                this.note_user_idField = value;
            }
        }

        /// <remarks/>
        public string[] resolution_id
        {
            get
            {
                return this.resolution_idField;
            }
            set
            {
                this.resolution_idField = value;
            }
        }

        /// <remarks/>
        public string[] product_version
        {
            get
            {
                return this.product_versionField;
            }
            set
            {
                this.product_versionField = value;
            }
        }

        /// <remarks/>
        public string[] user_monitor_id
        {
            get
            {
                return this.user_monitor_idField;
            }
            set
            {
                this.user_monitor_idField = value;
            }
        }

        /// <remarks/>
        public string[] hide_status_id
        {
            get
            {
                return this.hide_status_idField;
            }
            set
            {
                this.hide_status_idField = value;
            }
        }

        /// <remarks/>
        public string sort
        {
            get
            {
                return this.sortField;
            }
            set
            {
                this.sortField = value;
            }
        }

        /// <remarks/>
        public string sort_direction
        {
            get
            {
                return this.sort_directionField;
            }
            set
            {
                this.sort_directionField = value;
            }
        }

        /// <remarks/>
        public bool sticky
        {
            get
            {
                return this.stickyField;
            }
            set
            {
                this.stickyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool stickySpecified
        {
            get
            {
                return this.stickyFieldSpecified;
            }
            set
            {
                this.stickyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string[] view_state_id
        {
            get
            {
                return this.view_state_idField;
            }
            set
            {
                this.view_state_idField = value;
            }
        }

        /// <remarks/>
        public string[] fixed_in_version
        {
            get
            {
                return this.fixed_in_versionField;
            }
            set
            {
                this.fixed_in_versionField = value;
            }
        }

        /// <remarks/>
        public string[] target_version
        {
            get
            {
                return this.target_versionField;
            }
            set
            {
                this.target_versionField = value;
            }
        }

        /// <remarks/>
        public string[] platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        public string[] os
        {
            get
            {
                return this.osField;
            }
            set
            {
                this.osField = value;
            }
        }

        /// <remarks/>
        public string[] os_build
        {
            get
            {
                return this.os_buildField;
            }
            set
            {
                this.os_buildField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string start_day
        {
            get
            {
                return this.start_dayField;
            }
            set
            {
                this.start_dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string start_month
        {
            get
            {
                return this.start_monthField;
            }
            set
            {
                this.start_monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string start_year
        {
            get
            {
                return this.start_yearField;
            }
            set
            {
                this.start_yearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string end_day
        {
            get
            {
                return this.end_dayField;
            }
            set
            {
                this.end_dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string end_month
        {
            get
            {
                return this.end_monthField;
            }
            set
            {
                this.end_monthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string end_year
        {
            get
            {
                return this.end_yearField;
            }
            set
            {
                this.end_yearField = value;
            }
        }

        /// <remarks/>
        public string[] tag_string
        {
            get
            {
                return this.tag_stringField;
            }
            set
            {
                this.tag_stringField = value;
            }
        }

        /// <remarks/>
        public string[] tag_select
        {
            get
            {
                return this.tag_selectField;
            }
            set
            {
                this.tag_selectField = value;
            }
        }

        /// <remarks/>
        public FilterCustomField[] custom_fields
        {
            get
            {
                return this.custom_fieldsField;
            }
            set
            {
                this.custom_fieldsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class FilterData
    {

        private string idField;

        private AccountData ownerField;

        private string project_idField;

        private bool is_publicField;

        private bool is_publicFieldSpecified;

        private string nameField;

        private string filter_stringField;

        private string urlField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public AccountData owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string project_id
        {
            get
            {
                return this.project_idField;
            }
            set
            {
                this.project_idField = value;
            }
        }

        /// <remarks/>
        public bool is_public
        {
            get
            {
                return this.is_publicField;
            }
            set
            {
                this.is_publicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool is_publicSpecified
        {
            get
            {
                return this.is_publicFieldSpecified;
            }
            set
            {
                this.is_publicFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string filter_string
        {
            get
            {
                return this.filter_stringField;
            }
            set
            {
                this.filter_stringField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class CustomFieldDefinitionData
    {

        private ObjectRef fieldField;

        private string typeField;

        private string possible_valuesField;

        private string default_valueField;

        private string valid_regexpField;

        private string access_level_rField;

        private string access_level_rwField;

        private string length_minField;

        private string length_maxField;

        private bool advancedField;

        private bool advancedFieldSpecified;

        private bool display_reportField;

        private bool display_reportFieldSpecified;

        private bool display_updateField;

        private bool display_updateFieldSpecified;

        private bool display_resolvedField;

        private bool display_resolvedFieldSpecified;

        private bool display_closedField;

        private bool display_closedFieldSpecified;

        private bool require_reportField;

        private bool require_reportFieldSpecified;

        private bool require_updateField;

        private bool require_updateFieldSpecified;

        private bool require_resolvedField;

        private bool require_resolvedFieldSpecified;

        private bool require_closedField;

        private bool require_closedFieldSpecified;

        /// <remarks/>
        public ObjectRef field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string possible_values
        {
            get
            {
                return this.possible_valuesField;
            }
            set
            {
                this.possible_valuesField = value;
            }
        }

        /// <remarks/>
        public string default_value
        {
            get
            {
                return this.default_valueField;
            }
            set
            {
                this.default_valueField = value;
            }
        }

        /// <remarks/>
        public string valid_regexp
        {
            get
            {
                return this.valid_regexpField;
            }
            set
            {
                this.valid_regexpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string access_level_r
        {
            get
            {
                return this.access_level_rField;
            }
            set
            {
                this.access_level_rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string access_level_rw
        {
            get
            {
                return this.access_level_rwField;
            }
            set
            {
                this.access_level_rwField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string length_min
        {
            get
            {
                return this.length_minField;
            }
            set
            {
                this.length_minField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string length_max
        {
            get
            {
                return this.length_maxField;
            }
            set
            {
                this.length_maxField = value;
            }
        }

        /// <remarks/>
        public bool advanced
        {
            get
            {
                return this.advancedField;
            }
            set
            {
                this.advancedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool advancedSpecified
        {
            get
            {
                return this.advancedFieldSpecified;
            }
            set
            {
                this.advancedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool display_report
        {
            get
            {
                return this.display_reportField;
            }
            set
            {
                this.display_reportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool display_reportSpecified
        {
            get
            {
                return this.display_reportFieldSpecified;
            }
            set
            {
                this.display_reportFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool display_update
        {
            get
            {
                return this.display_updateField;
            }
            set
            {
                this.display_updateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool display_updateSpecified
        {
            get
            {
                return this.display_updateFieldSpecified;
            }
            set
            {
                this.display_updateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool display_resolved
        {
            get
            {
                return this.display_resolvedField;
            }
            set
            {
                this.display_resolvedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool display_resolvedSpecified
        {
            get
            {
                return this.display_resolvedFieldSpecified;
            }
            set
            {
                this.display_resolvedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool display_closed
        {
            get
            {
                return this.display_closedField;
            }
            set
            {
                this.display_closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool display_closedSpecified
        {
            get
            {
                return this.display_closedFieldSpecified;
            }
            set
            {
                this.display_closedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool require_report
        {
            get
            {
                return this.require_reportField;
            }
            set
            {
                this.require_reportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool require_reportSpecified
        {
            get
            {
                return this.require_reportFieldSpecified;
            }
            set
            {
                this.require_reportFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool require_update
        {
            get
            {
                return this.require_updateField;
            }
            set
            {
                this.require_updateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool require_updateSpecified
        {
            get
            {
                return this.require_updateFieldSpecified;
            }
            set
            {
                this.require_updateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool require_resolved
        {
            get
            {
                return this.require_resolvedField;
            }
            set
            {
                this.require_resolvedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool require_resolvedSpecified
        {
            get
            {
                return this.require_resolvedFieldSpecified;
            }
            set
            {
                this.require_resolvedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool require_closed
        {
            get
            {
                return this.require_closedField;
            }
            set
            {
                this.require_closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool require_closedSpecified
        {
            get
            {
                return this.require_closedFieldSpecified;
            }
            set
            {
                this.require_closedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class ProjectAttachmentData
    {

        private string idField;

        private string filenameField;

        private string titleField;

        private string descriptionField;

        private string sizeField;

        private string content_typeField;

        private System.DateTime date_submittedField;

        private bool date_submittedFieldSpecified;

        private string download_urlField;

        private string user_idField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public string content_type
        {
            get
            {
                return this.content_typeField;
            }
            set
            {
                this.content_typeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime date_submitted
        {
            get
            {
                return this.date_submittedField;
            }
            set
            {
                this.date_submittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool date_submittedSpecified
        {
            get
            {
                return this.date_submittedFieldSpecified;
            }
            set
            {
                this.date_submittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "anyURI")]
        public string download_url
        {
            get
            {
                return this.download_urlField;
            }
            set
            {
                this.download_urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string user_id
        {
            get
            {
                return this.user_idField;
            }
            set
            {
                this.user_idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class ProjectVersionData
    {

        private string idField;

        private string nameField;

        private string project_idField;

        private System.DateTime date_orderField;

        private bool date_orderFieldSpecified;

        private string descriptionField;

        private bool releasedField;

        private bool releasedFieldSpecified;

        private bool obsoleteField;

        private bool obsoleteFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string project_id
        {
            get
            {
                return this.project_idField;
            }
            set
            {
                this.project_idField = value;
            }
        }

        /// <remarks/>
        public System.DateTime date_order
        {
            get
            {
                return this.date_orderField;
            }
            set
            {
                this.date_orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool date_orderSpecified
        {
            get
            {
                return this.date_orderFieldSpecified;
            }
            set
            {
                this.date_orderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public bool released
        {
            get
            {
                return this.releasedField;
            }
            set
            {
                this.releasedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool releasedSpecified
        {
            get
            {
                return this.releasedFieldSpecified;
            }
            set
            {
                this.releasedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool obsolete
        {
            get
            {
                return this.obsoleteField;
            }
            set
            {
                this.obsoleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool obsoleteSpecified
        {
            get
            {
                return this.obsoleteFieldSpecified;
            }
            set
            {
                this.obsoleteFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class ProjectData
    {

        private string idField;

        private string nameField;

        private ObjectRef statusField;

        private bool enabledField;

        private bool enabledFieldSpecified;

        private ObjectRef view_stateField;

        private ObjectRef access_minField;

        private string file_pathField;

        private string descriptionField;

        private ProjectData[] subprojectsField;

        private bool inherit_globalField;

        private bool inherit_globalFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ObjectRef status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool enabledSpecified
        {
            get
            {
                return this.enabledFieldSpecified;
            }
            set
            {
                this.enabledFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ObjectRef view_state
        {
            get
            {
                return this.view_stateField;
            }
            set
            {
                this.view_stateField = value;
            }
        }

        /// <remarks/>
        public ObjectRef access_min
        {
            get
            {
                return this.access_minField;
            }
            set
            {
                this.access_minField = value;
            }
        }

        /// <remarks/>
        public string file_path
        {
            get
            {
                return this.file_pathField;
            }
            set
            {
                this.file_pathField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public ProjectData[] subprojects
        {
            get
            {
                return this.subprojectsField;
            }
            set
            {
                this.subprojectsField = value;
            }
        }

        /// <remarks/>
        public bool inherit_global
        {
            get
            {
                return this.inherit_globalField;
            }
            set
            {
                this.inherit_globalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool inherit_globalSpecified
        {
            get
            {
                return this.inherit_globalFieldSpecified;
            }
            set
            {
                this.inherit_globalFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class HistoryData
    {

        private string dateField;

        private string useridField;

        private string usernameField;

        private string fieldField;

        private string typeField;

        private string old_valueField;

        private string new_valueField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string userid
        {
            get
            {
                return this.useridField;
            }
            set
            {
                this.useridField = value;
            }
        }

        /// <remarks/>
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public string field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string old_value
        {
            get
            {
                return this.old_valueField;
            }
            set
            {
                this.old_valueField = value;
            }
        }

        /// <remarks/>
        public string new_value
        {
            get
            {
                return this.new_valueField;
            }
            set
            {
                this.new_valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class IssueHeaderData
    {

        private string idField;

        private string view_stateField;

        private System.DateTime last_updatedField;

        private string projectField;

        private string categoryField;

        private string priorityField;

        private string severityField;

        private string statusField;

        private string reporterField;

        private string summaryField;

        private string handlerField;

        private string resolutionField;

        private string attachments_countField;

        private string notes_countField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string view_state
        {
            get
            {
                return this.view_stateField;
            }
            set
            {
                this.view_stateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime last_updated
        {
            get
            {
                return this.last_updatedField;
            }
            set
            {
                this.last_updatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string project
        {
            get
            {
                return this.projectField;
            }
            set
            {
                this.projectField = value;
            }
        }

        /// <remarks/>
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string reporter
        {
            get
            {
                return this.reporterField;
            }
            set
            {
                this.reporterField = value;
            }
        }

        /// <remarks/>
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string handler
        {
            get
            {
                return this.handlerField;
            }
            set
            {
                this.handlerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string attachments_count
        {
            get
            {
                return this.attachments_countField;
            }
            set
            {
                this.attachments_countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string notes_count
        {
            get
            {
                return this.notes_countField;
            }
            set
            {
                this.notes_countField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class CustomFieldValueForIssueData
    {

        private ObjectRef fieldField;

        private string valueField;

        /// <remarks/>
        public ObjectRef field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class IssueNoteData
    {

        private string idField;

        private AccountData reporterField;

        private string textField;

        private ObjectRef view_stateField;

        private System.DateTime date_submittedField;

        private bool date_submittedFieldSpecified;

        private System.DateTime last_modifiedField;

        private bool last_modifiedFieldSpecified;

        private string time_trackingField;

        private string note_typeField;

        private string note_attrField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public AccountData reporter
        {
            get
            {
                return this.reporterField;
            }
            set
            {
                this.reporterField = value;
            }
        }

        /// <remarks/>
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public ObjectRef view_state
        {
            get
            {
                return this.view_stateField;
            }
            set
            {
                this.view_stateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime date_submitted
        {
            get
            {
                return this.date_submittedField;
            }
            set
            {
                this.date_submittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool date_submittedSpecified
        {
            get
            {
                return this.date_submittedFieldSpecified;
            }
            set
            {
                this.date_submittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime last_modified
        {
            get
            {
                return this.last_modifiedField;
            }
            set
            {
                this.last_modifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool last_modifiedSpecified
        {
            get
            {
                return this.last_modifiedFieldSpecified;
            }
            set
            {
                this.last_modifiedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string time_tracking
        {
            get
            {
                return this.time_trackingField;
            }
            set
            {
                this.time_trackingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string note_type
        {
            get
            {
                return this.note_typeField;
            }
            set
            {
                this.note_typeField = value;
            }
        }

        /// <remarks/>
        public string note_attr
        {
            get
            {
                return this.note_attrField;
            }
            set
            {
                this.note_attrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class RelationshipData
    {

        private string idField;

        private ObjectRef typeField;

        private string target_idField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public ObjectRef type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string target_id
        {
            get
            {
                return this.target_idField;
            }
            set
            {
                this.target_idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class AttachmentData
    {

        private string idField;

        private string filenameField;

        private string sizeField;

        private string content_typeField;

        private System.DateTime date_submittedField;

        private bool date_submittedFieldSpecified;

        private string download_urlField;

        private string user_idField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public string content_type
        {
            get
            {
                return this.content_typeField;
            }
            set
            {
                this.content_typeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime date_submitted
        {
            get
            {
                return this.date_submittedField;
            }
            set
            {
                this.date_submittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool date_submittedSpecified
        {
            get
            {
                return this.date_submittedFieldSpecified;
            }
            set
            {
                this.date_submittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "anyURI")]
        public string download_url
        {
            get
            {
                return this.download_urlField;
            }
            set
            {
                this.download_urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string user_id
        {
            get
            {
                return this.user_idField;
            }
            set
            {
                this.user_idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://futureware.biz/mantisconnect")]
    public partial class IssueData
    {

        private string idField;

        private ObjectRef view_stateField;

        private System.DateTime last_updatedField;

        private bool last_updatedFieldSpecified;

        private ObjectRef projectField;

        private string categoryField;

        private ObjectRef priorityField;

        private ObjectRef severityField;

        private ObjectRef statusField;

        private AccountData reporterField;

        private string summaryField;

        private string versionField;

        private string buildField;

        private string platformField;

        private string osField;

        private string os_buildField;

        private ObjectRef reproducibilityField;

        private System.DateTime date_submittedField;

        private bool date_submittedFieldSpecified;

        private string sponsorship_totalField;

        private AccountData handlerField;

        private ObjectRef projectionField;

        private ObjectRef etaField;

        private ObjectRef resolutionField;

        private string fixed_in_versionField;

        private string target_versionField;

        private string descriptionField;

        private string steps_to_reproduceField;

        private string additional_informationField;

        private AttachmentData[] attachmentsField;

        private RelationshipData[] relationshipsField;

        private IssueNoteData[] notesField;

        private CustomFieldValueForIssueData[] custom_fieldsField;

        private System.DateTime due_dateField;

        private bool due_dateFieldSpecified;

        private AccountData[] monitorsField;

        private bool stickyField;

        private bool stickyFieldSpecified;

        private ObjectRef[] tagsField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public ObjectRef view_state
        {
            get
            {
                return this.view_stateField;
            }
            set
            {
                this.view_stateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime last_updated
        {
            get
            {
                return this.last_updatedField;
            }
            set
            {
                this.last_updatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool last_updatedSpecified
        {
            get
            {
                return this.last_updatedFieldSpecified;
            }
            set
            {
                this.last_updatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ObjectRef project
        {
            get
            {
                return this.projectField;
            }
            set
            {
                this.projectField = value;
            }
        }

        /// <remarks/>
        public string category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public ObjectRef priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public ObjectRef severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public ObjectRef status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public AccountData reporter
        {
            get
            {
                return this.reporterField;
            }
            set
            {
                this.reporterField = value;
            }
        }

        /// <remarks/>
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string build
        {
            get
            {
                return this.buildField;
            }
            set
            {
                this.buildField = value;
            }
        }

        /// <remarks/>
        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        public string os
        {
            get
            {
                return this.osField;
            }
            set
            {
                this.osField = value;
            }
        }

        /// <remarks/>
        public string os_build
        {
            get
            {
                return this.os_buildField;
            }
            set
            {
                this.os_buildField = value;
            }
        }

        /// <remarks/>
        public ObjectRef reproducibility
        {
            get
            {
                return this.reproducibilityField;
            }
            set
            {
                this.reproducibilityField = value;
            }
        }

        /// <remarks/>
        public System.DateTime date_submitted
        {
            get
            {
                return this.date_submittedField;
            }
            set
            {
                this.date_submittedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool date_submittedSpecified
        {
            get
            {
                return this.date_submittedFieldSpecified;
            }
            set
            {
                this.date_submittedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(DataType = "integer")]
        public string sponsorship_total
        {
            get
            {
                return this.sponsorship_totalField;
            }
            set
            {
                this.sponsorship_totalField = value;
            }
        }

        /// <remarks/>
        public AccountData handler
        {
            get
            {
                return this.handlerField;
            }
            set
            {
                this.handlerField = value;
            }
        }

        /// <remarks/>
        public ObjectRef projection
        {
            get
            {
                return this.projectionField;
            }
            set
            {
                this.projectionField = value;
            }
        }

        /// <remarks/>
        public ObjectRef eta
        {
            get
            {
                return this.etaField;
            }
            set
            {
                this.etaField = value;
            }
        }

        /// <remarks/>
        public ObjectRef resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        /// <remarks/>
        public string fixed_in_version
        {
            get
            {
                return this.fixed_in_versionField;
            }
            set
            {
                this.fixed_in_versionField = value;
            }
        }

        /// <remarks/>
        public string target_version
        {
            get
            {
                return this.target_versionField;
            }
            set
            {
                this.target_versionField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string steps_to_reproduce
        {
            get
            {
                return this.steps_to_reproduceField;
            }
            set
            {
                this.steps_to_reproduceField = value;
            }
        }

        /// <remarks/>
        public string additional_information
        {
            get
            {
                return this.additional_informationField;
            }
            set
            {
                this.additional_informationField = value;
            }
        }

        /// <remarks/>
        public AttachmentData[] attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }

        /// <remarks/>
        public RelationshipData[] relationships
        {
            get
            {
                return this.relationshipsField;
            }
            set
            {
                this.relationshipsField = value;
            }
        }

        /// <remarks/>
        public IssueNoteData[] notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public CustomFieldValueForIssueData[] custom_fields
        {
            get
            {
                return this.custom_fieldsField;
            }
            set
            {
                this.custom_fieldsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime due_date
        {
            get
            {
                return this.due_dateField;
            }
            set
            {
                this.due_dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool due_dateSpecified
        {
            get
            {
                return this.due_dateFieldSpecified;
            }
            set
            {
                this.due_dateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public AccountData[] monitors
        {
            get
            {
                return this.monitorsField;
            }
            set
            {
                this.monitorsField = value;
            }
        }

        /// <remarks/>
        public bool sticky
        {
            get
            {
                return this.stickyField;
            }
            set
            {
                this.stickyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapIgnoreAttribute()]
        public bool stickySpecified
        {
            get
            {
                return this.stickyFieldSpecified;
            }
            set
            {
                this.stickyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ObjectRef[] tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MantisConnectPortTypeChannel : MantisConnectPortType, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MantisConnectPortTypeClient : System.ServiceModel.ClientBase<MantisConnectPortType>, MantisConnectPortType
    {

        public MantisConnectPortTypeClient()
        {
        }

        public MantisConnectPortTypeClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public MantisConnectPortTypeClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public MantisConnectPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public MantisConnectPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public string mc_version()
        {
            return base.Channel.mc_version();
        }

        public System.Threading.Tasks.Task<string> mc_versionAsync()
        {
            return base.Channel.mc_versionAsync();
        }

        public UserData mc_login(string username, string password)
        {
            return base.Channel.mc_login(username, password);
        }

        public System.Threading.Tasks.Task<UserData> mc_loginAsync(string username, string password)
        {
            return base.Channel.mc_loginAsync(username, password);
        }

        public ObjectRef[] mc_enum_status(string username, string password)
        {
            return base.Channel.mc_enum_status(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_statusAsync(string username, string password)
        {
            return base.Channel.mc_enum_statusAsync(username, password);
        }

        public ObjectRef[] mc_enum_priorities(string username, string password)
        {
            return base.Channel.mc_enum_priorities(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_prioritiesAsync(string username, string password)
        {
            return base.Channel.mc_enum_prioritiesAsync(username, password);
        }

        public ObjectRef[] mc_enum_severities(string username, string password)
        {
            return base.Channel.mc_enum_severities(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_severitiesAsync(string username, string password)
        {
            return base.Channel.mc_enum_severitiesAsync(username, password);
        }

        public ObjectRef[] mc_enum_reproducibilities(string username, string password)
        {
            return base.Channel.mc_enum_reproducibilities(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_reproducibilitiesAsync(string username, string password)
        {
            return base.Channel.mc_enum_reproducibilitiesAsync(username, password);
        }

        public ObjectRef[] mc_enum_projections(string username, string password)
        {
            return base.Channel.mc_enum_projections(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_projectionsAsync(string username, string password)
        {
            return base.Channel.mc_enum_projectionsAsync(username, password);
        }

        public ObjectRef[] mc_enum_etas(string username, string password)
        {
            return base.Channel.mc_enum_etas(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_etasAsync(string username, string password)
        {
            return base.Channel.mc_enum_etasAsync(username, password);
        }

        public ObjectRef[] mc_enum_resolutions(string username, string password)
        {
            return base.Channel.mc_enum_resolutions(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_resolutionsAsync(string username, string password)
        {
            return base.Channel.mc_enum_resolutionsAsync(username, password);
        }

        public ObjectRef[] mc_enum_access_levels(string username, string password)
        {
            return base.Channel.mc_enum_access_levels(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_access_levelsAsync(string username, string password)
        {
            return base.Channel.mc_enum_access_levelsAsync(username, password);
        }

        public ObjectRef[] mc_enum_project_status(string username, string password)
        {
            return base.Channel.mc_enum_project_status(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_project_statusAsync(string username, string password)
        {
            return base.Channel.mc_enum_project_statusAsync(username, password);
        }

        public ObjectRef[] mc_enum_project_view_states(string username, string password)
        {
            return base.Channel.mc_enum_project_view_states(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_project_view_statesAsync(string username, string password)
        {
            return base.Channel.mc_enum_project_view_statesAsync(username, password);
        }

        public ObjectRef[] mc_enum_view_states(string username, string password)
        {
            return base.Channel.mc_enum_view_states(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_view_statesAsync(string username, string password)
        {
            return base.Channel.mc_enum_view_statesAsync(username, password);
        }

        public ObjectRef[] mc_enum_custom_field_types(string username, string password)
        {
            return base.Channel.mc_enum_custom_field_types(username, password);
        }

        public System.Threading.Tasks.Task<ObjectRef[]> mc_enum_custom_field_typesAsync(string username, string password)
        {
            return base.Channel.mc_enum_custom_field_typesAsync(username, password);
        }

        public string mc_enum_get(string username, string password, string enumeration)
        {
            return base.Channel.mc_enum_get(username, password, enumeration);
        }

        public System.Threading.Tasks.Task<string> mc_enum_getAsync(string username, string password, string enumeration)
        {
            return base.Channel.mc_enum_getAsync(username, password, enumeration);
        }

        public bool mc_issue_exists(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_exists(username, password, issue_id);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_existsAsync(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_existsAsync(username, password, issue_id);
        }

        public IssueData mc_issue_get(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_get(username, password, issue_id);
        }

        public System.Threading.Tasks.Task<IssueData> mc_issue_getAsync(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_getAsync(username, password, issue_id);
        }

        public IssueData[] mc_issues_get(string username, string password, string[] issue_ids)
        {
            return base.Channel.mc_issues_get(username, password, issue_ids);
        }

        public System.Threading.Tasks.Task<IssueData[]> mc_issues_getAsync(string username, string password, string[] issue_ids)
        {
            return base.Channel.mc_issues_getAsync(username, password, issue_ids);
        }

        public IssueHeaderData[] mc_issues_get_header(string username, string password, string[] issue_ids)
        {
            return base.Channel.mc_issues_get_header(username, password, issue_ids);
        }

        public System.Threading.Tasks.Task<IssueHeaderData[]> mc_issues_get_headerAsync(string username, string password, string[] issue_ids)
        {
            return base.Channel.mc_issues_get_headerAsync(username, password, issue_ids);
        }

        public HistoryData[] mc_issue_get_history(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_get_history(username, password, issue_id);
        }

        public System.Threading.Tasks.Task<HistoryData[]> mc_issue_get_historyAsync(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_get_historyAsync(username, password, issue_id);
        }

        public string mc_issue_get_biggest_id(string username, string password, string project_id)
        {
            return base.Channel.mc_issue_get_biggest_id(username, password, project_id);
        }

        public System.Threading.Tasks.Task<string> mc_issue_get_biggest_idAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_issue_get_biggest_idAsync(username, password, project_id);
        }

        public string mc_issue_get_id_from_summary(string username, string password, string summary)
        {
            return base.Channel.mc_issue_get_id_from_summary(username, password, summary);
        }

        public System.Threading.Tasks.Task<string> mc_issue_get_id_from_summaryAsync(string username, string password, string summary)
        {
            return base.Channel.mc_issue_get_id_from_summaryAsync(username, password, summary);
        }

        public string mc_issue_add(string username, string password, IssueData issue)
        {
            return base.Channel.mc_issue_add(username, password, issue);
        }

        public System.Threading.Tasks.Task<string> mc_issue_addAsync(string username, string password, IssueData issue)
        {
            return base.Channel.mc_issue_addAsync(username, password, issue);
        }

        public bool mc_issue_update(string username, string password, string issueId, IssueData issue)
        {
            return base.Channel.mc_issue_update(username, password, issueId, issue);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_updateAsync(string username, string password, string issueId, IssueData issue)
        {
            return base.Channel.mc_issue_updateAsync(username, password, issueId, issue);
        }

        public bool mc_issue_set_tags(string username, string password, string issue_id, TagData[] tags)
        {
            return base.Channel.mc_issue_set_tags(username, password, issue_id, tags);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_set_tagsAsync(string username, string password, string issue_id, TagData[] tags)
        {
            return base.Channel.mc_issue_set_tagsAsync(username, password, issue_id, tags);
        }

        public bool mc_issue_delete(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_delete(username, password, issue_id);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_deleteAsync(string username, string password, string issue_id)
        {
            return base.Channel.mc_issue_deleteAsync(username, password, issue_id);
        }

        public string mc_issue_note_add(string username, string password, string issue_id, IssueNoteData note)
        {
            return base.Channel.mc_issue_note_add(username, password, issue_id, note);
        }

        public System.Threading.Tasks.Task<string> mc_issue_note_addAsync(string username, string password, string issue_id, IssueNoteData note)
        {
            return base.Channel.mc_issue_note_addAsync(username, password, issue_id, note);
        }

        public bool mc_issue_note_delete(string username, string password, string issue_note_id)
        {
            return base.Channel.mc_issue_note_delete(username, password, issue_note_id);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_note_deleteAsync(string username, string password, string issue_note_id)
        {
            return base.Channel.mc_issue_note_deleteAsync(username, password, issue_note_id);
        }

        public bool mc_issue_note_update(string username, string password, IssueNoteData note)
        {
            return base.Channel.mc_issue_note_update(username, password, note);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_note_updateAsync(string username, string password, IssueNoteData note)
        {
            return base.Channel.mc_issue_note_updateAsync(username, password, note);
        }

        public string mc_issue_relationship_add(string username, string password, string issue_id, RelationshipData relationship)
        {
            return base.Channel.mc_issue_relationship_add(username, password, issue_id, relationship);
        }

        public System.Threading.Tasks.Task<string> mc_issue_relationship_addAsync(string username, string password, string issue_id, RelationshipData relationship)
        {
            return base.Channel.mc_issue_relationship_addAsync(username, password, issue_id, relationship);
        }

        public bool mc_issue_relationship_delete(string username, string password, string issue_id, string relationship_id)
        {
            return base.Channel.mc_issue_relationship_delete(username, password, issue_id, relationship_id);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_relationship_deleteAsync(string username, string password, string issue_id, string relationship_id)
        {
            return base.Channel.mc_issue_relationship_deleteAsync(username, password, issue_id, relationship_id);
        }

        public string mc_issue_attachment_add(string username, string password, string issue_id, string name, string file_type, byte[] content)
        {
            return base.Channel.mc_issue_attachment_add(username, password, issue_id, name, file_type, content);
        }

        public System.Threading.Tasks.Task<string> mc_issue_attachment_addAsync(string username, string password, string issue_id, string name, string file_type, byte[] content)
        {
            return base.Channel.mc_issue_attachment_addAsync(username, password, issue_id, name, file_type, content);
        }

        public bool mc_issue_attachment_delete(string username, string password, string issue_attachment_id)
        {
            return base.Channel.mc_issue_attachment_delete(username, password, issue_attachment_id);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_attachment_deleteAsync(string username, string password, string issue_attachment_id)
        {
            return base.Channel.mc_issue_attachment_deleteAsync(username, password, issue_attachment_id);
        }

        public byte[] mc_issue_attachment_get(string username, string password, string issue_attachment_id)
        {
            return base.Channel.mc_issue_attachment_get(username, password, issue_attachment_id);
        }

        public System.Threading.Tasks.Task<byte[]> mc_issue_attachment_getAsync(string username, string password, string issue_attachment_id)
        {
            return base.Channel.mc_issue_attachment_getAsync(username, password, issue_attachment_id);
        }

        public string mc_project_add(string username, string password, ProjectData project)
        {
            return base.Channel.mc_project_add(username, password, project);
        }

        public System.Threading.Tasks.Task<string> mc_project_addAsync(string username, string password, ProjectData project)
        {
            return base.Channel.mc_project_addAsync(username, password, project);
        }

        public bool mc_project_delete(string username, string password, string project_id)
        {
            return base.Channel.mc_project_delete(username, password, project_id);
        }

        public System.Threading.Tasks.Task<bool> mc_project_deleteAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_deleteAsync(username, password, project_id);
        }

        public bool mc_project_update(string username, string password, string project_id, ProjectData project)
        {
            return base.Channel.mc_project_update(username, password, project_id, project);
        }

        public System.Threading.Tasks.Task<bool> mc_project_updateAsync(string username, string password, string project_id, ProjectData project)
        {
            return base.Channel.mc_project_updateAsync(username, password, project_id, project);
        }

        public string mc_project_get_id_from_name(string username, string password, string project_name)
        {
            return base.Channel.mc_project_get_id_from_name(username, password, project_name);
        }

        public System.Threading.Tasks.Task<string> mc_project_get_id_from_nameAsync(string username, string password, string project_name)
        {
            return base.Channel.mc_project_get_id_from_nameAsync(username, password, project_name);
        }

        public IssueData[] mc_project_get_issues_for_user(string username, string password, string project_id, string filter_type, AccountData target_user, string page_number, string per_page)
        {
            return base.Channel.mc_project_get_issues_for_user(username, password, project_id, filter_type, target_user, page_number, per_page);
        }

        public System.Threading.Tasks.Task<IssueData[]> mc_project_get_issues_for_userAsync(string username, string password, string project_id, string filter_type, AccountData target_user, string page_number, string per_page)
        {
            return base.Channel.mc_project_get_issues_for_userAsync(username, password, project_id, filter_type, target_user, page_number, per_page);
        }

        public IssueData[] mc_project_get_issues(string username, string password, string project_id, string page_number, string per_page)
        {
            return base.Channel.mc_project_get_issues(username, password, project_id, page_number, per_page);
        }

        public System.Threading.Tasks.Task<IssueData[]> mc_project_get_issuesAsync(string username, string password, string project_id, string page_number, string per_page)
        {
            return base.Channel.mc_project_get_issuesAsync(username, password, project_id, page_number, per_page);
        }

        public IssueHeaderData[] mc_project_get_issue_headers(string username, string password, string project_id, string page_number, string per_page)
        {
            return base.Channel.mc_project_get_issue_headers(username, password, project_id, page_number, per_page);
        }

        public System.Threading.Tasks.Task<IssueHeaderData[]> mc_project_get_issue_headersAsync(string username, string password, string project_id, string page_number, string per_page)
        {
            return base.Channel.mc_project_get_issue_headersAsync(username, password, project_id, page_number, per_page);
        }

        public AccountData[] mc_project_get_users(string username, string password, string project_id, string access)
        {
            return base.Channel.mc_project_get_users(username, password, project_id, access);
        }

        public System.Threading.Tasks.Task<AccountData[]> mc_project_get_usersAsync(string username, string password, string project_id, string access)
        {
            return base.Channel.mc_project_get_usersAsync(username, password, project_id, access);
        }

        public ProjectData[] mc_projects_get_user_accessible(string username, string password)
        {
            return base.Channel.mc_projects_get_user_accessible(username, password);
        }

        public System.Threading.Tasks.Task<ProjectData[]> mc_projects_get_user_accessibleAsync(string username, string password)
        {
            return base.Channel.mc_projects_get_user_accessibleAsync(username, password);
        }

        public string[] mc_project_get_categories(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_categories(username, password, project_id);
        }

        public System.Threading.Tasks.Task<string[]> mc_project_get_categoriesAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_categoriesAsync(username, password, project_id);
        }

        public string mc_project_add_category(string username, string password, string project_id, string p_category_name)
        {
            return base.Channel.mc_project_add_category(username, password, project_id, p_category_name);
        }

        public System.Threading.Tasks.Task<string> mc_project_add_categoryAsync(string username, string password, string project_id, string p_category_name)
        {
            return base.Channel.mc_project_add_categoryAsync(username, password, project_id, p_category_name);
        }

        public string mc_project_delete_category(string username, string password, string project_id, string p_category_name)
        {
            return base.Channel.mc_project_delete_category(username, password, project_id, p_category_name);
        }

        public System.Threading.Tasks.Task<string> mc_project_delete_categoryAsync(string username, string password, string project_id, string p_category_name)
        {
            return base.Channel.mc_project_delete_categoryAsync(username, password, project_id, p_category_name);
        }

        public string mc_project_rename_category_by_name(string username, string password, string project_id, string p_category_name, string p_category_name_new, string p_assigned_to)
        {
            return base.Channel.mc_project_rename_category_by_name(username, password, project_id, p_category_name, p_category_name_new, p_assigned_to);
        }

        public System.Threading.Tasks.Task<string> mc_project_rename_category_by_nameAsync(string username, string password, string project_id, string p_category_name, string p_category_name_new, string p_assigned_to)
        {
            return base.Channel.mc_project_rename_category_by_nameAsync(username, password, project_id, p_category_name, p_category_name_new, p_assigned_to);
        }

        public ProjectVersionData[] mc_project_get_versions(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_versions(username, password, project_id);
        }

        public System.Threading.Tasks.Task<ProjectVersionData[]> mc_project_get_versionsAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_versionsAsync(username, password, project_id);
        }

        public string mc_project_version_add(string username, string password, ProjectVersionData version)
        {
            return base.Channel.mc_project_version_add(username, password, version);
        }

        public System.Threading.Tasks.Task<string> mc_project_version_addAsync(string username, string password, ProjectVersionData version)
        {
            return base.Channel.mc_project_version_addAsync(username, password, version);
        }

        public bool mc_project_version_update(string username, string password, string version_id, ProjectVersionData version)
        {
            return base.Channel.mc_project_version_update(username, password, version_id, version);
        }

        public System.Threading.Tasks.Task<bool> mc_project_version_updateAsync(string username, string password, string version_id, ProjectVersionData version)
        {
            return base.Channel.mc_project_version_updateAsync(username, password, version_id, version);
        }

        public bool mc_project_version_delete(string username, string password, string version_id)
        {
            return base.Channel.mc_project_version_delete(username, password, version_id);
        }

        public System.Threading.Tasks.Task<bool> mc_project_version_deleteAsync(string username, string password, string version_id)
        {
            return base.Channel.mc_project_version_deleteAsync(username, password, version_id);
        }

        public ProjectVersionData[] mc_project_get_released_versions(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_released_versions(username, password, project_id);
        }

        public System.Threading.Tasks.Task<ProjectVersionData[]> mc_project_get_released_versionsAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_released_versionsAsync(username, password, project_id);
        }

        public ProjectVersionData[] mc_project_get_unreleased_versions(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_unreleased_versions(username, password, project_id);
        }

        public System.Threading.Tasks.Task<ProjectVersionData[]> mc_project_get_unreleased_versionsAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_unreleased_versionsAsync(username, password, project_id);
        }

        public ProjectAttachmentData[] mc_project_get_attachments(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_attachments(username, password, project_id);
        }

        public System.Threading.Tasks.Task<ProjectAttachmentData[]> mc_project_get_attachmentsAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_attachmentsAsync(username, password, project_id);
        }

        public CustomFieldDefinitionData[] mc_project_get_custom_fields(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_custom_fields(username, password, project_id);
        }

        public System.Threading.Tasks.Task<CustomFieldDefinitionData[]> mc_project_get_custom_fieldsAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_custom_fieldsAsync(username, password, project_id);
        }

        public byte[] mc_project_attachment_get(string username, string password, string project_attachment_id)
        {
            return base.Channel.mc_project_attachment_get(username, password, project_attachment_id);
        }

        public System.Threading.Tasks.Task<byte[]> mc_project_attachment_getAsync(string username, string password, string project_attachment_id)
        {
            return base.Channel.mc_project_attachment_getAsync(username, password, project_attachment_id);
        }

        public string mc_project_attachment_add(string username, string password, string project_id, string name, string title, string description, string file_type, byte[] content)
        {
            return base.Channel.mc_project_attachment_add(username, password, project_id, name, title, description, file_type, content);
        }

        public System.Threading.Tasks.Task<string> mc_project_attachment_addAsync(string username, string password, string project_id, string name, string title, string description, string file_type, byte[] content)
        {
            return base.Channel.mc_project_attachment_addAsync(username, password, project_id, name, title, description, file_type, content);
        }

        public bool mc_project_attachment_delete(string username, string password, string project_attachment_id)
        {
            return base.Channel.mc_project_attachment_delete(username, password, project_attachment_id);
        }

        public System.Threading.Tasks.Task<bool> mc_project_attachment_deleteAsync(string username, string password, string project_attachment_id)
        {
            return base.Channel.mc_project_attachment_deleteAsync(username, password, project_attachment_id);
        }

        public string[] mc_project_get_all_subprojects(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_all_subprojects(username, password, project_id);
        }

        public System.Threading.Tasks.Task<string[]> mc_project_get_all_subprojectsAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_project_get_all_subprojectsAsync(username, password, project_id);
        }

        public FilterData[] mc_filter_get(string username, string password, string project_id)
        {
            return base.Channel.mc_filter_get(username, password, project_id);
        }

        public System.Threading.Tasks.Task<FilterData[]> mc_filter_getAsync(string username, string password, string project_id)
        {
            return base.Channel.mc_filter_getAsync(username, password, project_id);
        }

        public IssueData[] mc_filter_get_issues(string username, string password, string project_id, string filter_id, string page_number, string per_page)
        {
            return base.Channel.mc_filter_get_issues(username, password, project_id, filter_id, page_number, per_page);
        }

        public System.Threading.Tasks.Task<IssueData[]> mc_filter_get_issuesAsync(string username, string password, string project_id, string filter_id, string page_number, string per_page)
        {
            return base.Channel.mc_filter_get_issuesAsync(username, password, project_id, filter_id, page_number, per_page);
        }

        public IssueHeaderData[] mc_filter_get_issue_headers(string username, string password, string project_id, string filter_id, string page_number, string per_page)
        {
            return base.Channel.mc_filter_get_issue_headers(username, password, project_id, filter_id, page_number, per_page);
        }

        public System.Threading.Tasks.Task<IssueHeaderData[]> mc_filter_get_issue_headersAsync(string username, string password, string project_id, string filter_id, string page_number, string per_page)
        {
            return base.Channel.mc_filter_get_issue_headersAsync(username, password, project_id, filter_id, page_number, per_page);
        }

        public IssueHeaderData[] mc_filter_search_issue_headers(string username, string password, FilterSearchData filter, string page_number, string per_page)
        {
            return base.Channel.mc_filter_search_issue_headers(username, password, filter, page_number, per_page);
        }

        public System.Threading.Tasks.Task<IssueHeaderData[]> mc_filter_search_issue_headersAsync(string username, string password, FilterSearchData filter, string page_number, string per_page)
        {
            return base.Channel.mc_filter_search_issue_headersAsync(username, password, filter, page_number, per_page);
        }

        public IssueData[] mc_filter_search_issues(string username, string password, FilterSearchData filter, string page_number, string per_page)
        {
            return base.Channel.mc_filter_search_issues(username, password, filter, page_number, per_page);
        }

        public System.Threading.Tasks.Task<IssueData[]> mc_filter_search_issuesAsync(string username, string password, FilterSearchData filter, string page_number, string per_page)
        {
            return base.Channel.mc_filter_search_issuesAsync(username, password, filter, page_number, per_page);
        }

        public string[] mc_filter_search_issue_ids(string username, string password, FilterSearchData filter, string page_number, string per_page)
        {
            return base.Channel.mc_filter_search_issue_ids(username, password, filter, page_number, per_page);
        }

        public System.Threading.Tasks.Task<string[]> mc_filter_search_issue_idsAsync(string username, string password, FilterSearchData filter, string page_number, string per_page)
        {
            return base.Channel.mc_filter_search_issue_idsAsync(username, password, filter, page_number, per_page);
        }

        public string mc_config_get_string(string username, string password, string config_var)
        {
            return base.Channel.mc_config_get_string(username, password, config_var);
        }

        public System.Threading.Tasks.Task<string> mc_config_get_stringAsync(string username, string password, string config_var)
        {
            return base.Channel.mc_config_get_stringAsync(username, password, config_var);
        }

        public bool mc_issue_checkin(string username, string password, string issue_id, string comment, bool @fixed)
        {
            return base.Channel.mc_issue_checkin(username, password, issue_id, comment, @fixed);
        }

        public System.Threading.Tasks.Task<bool> mc_issue_checkinAsync(string username, string password, string issue_id, string comment, bool @fixed)
        {
            return base.Channel.mc_issue_checkinAsync(username, password, issue_id, comment, @fixed);
        }

        public string mc_user_pref_get_pref(string username, string password, string project_id, string pref_name)
        {
            return base.Channel.mc_user_pref_get_pref(username, password, project_id, pref_name);
        }

        public System.Threading.Tasks.Task<string> mc_user_pref_get_prefAsync(string username, string password, string project_id, string pref_name)
        {
            return base.Channel.mc_user_pref_get_prefAsync(username, password, project_id, pref_name);
        }

        public ProfileDataSearchResult mc_user_profiles_get_all(string username, string password, string page_number, string per_page)
        {
            return base.Channel.mc_user_profiles_get_all(username, password, page_number.ToString(), per_page.ToString());
        }

        public System.Threading.Tasks.Task<ProfileDataSearchResult> mc_user_profiles_get_allAsync(string username, string password, string page_number, string per_page)
        {
            return base.Channel.mc_user_profiles_get_allAsync(username, password, page_number.ToString(), per_page.ToString());
        }

        public TagDataSearchResult mc_tag_get_all(string username, string password, string page_number, string per_page)
        {
            return base.Channel.mc_tag_get_all(username, password, page_number, per_page);
        }

        public System.Threading.Tasks.Task<TagDataSearchResult> mc_tag_get_allAsync(string username, string password, string page_number, string per_page)
        {
            return base.Channel.mc_tag_get_allAsync(username, password, page_number, per_page);
        }

        public string mc_tag_add(string username, string password, TagData tag)
        {
            return base.Channel.mc_tag_add(username, password, tag);
        }

        public System.Threading.Tasks.Task<string> mc_tag_addAsync(string username, string password, TagData tag)
        {
            return base.Channel.mc_tag_addAsync(username, password, tag);
        }

        public bool mc_tag_delete(string username, string password, string tag_id)
        {
            return base.Channel.mc_tag_delete(username, password, tag_id);
        }

        public System.Threading.Tasks.Task<bool> mc_tag_deleteAsync(string username, string password, string tag_id)
        {
            return base.Channel.mc_tag_deleteAsync(username, password, tag_id);
        }
    }
}