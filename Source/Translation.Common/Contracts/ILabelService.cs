﻿using System.Threading.Tasks;

using Translation.Common.Models.Requests.Label;
using Translation.Common.Models.Requests.Label.LabelTranslation;
using Translation.Common.Models.Responses.Label;
using Translation.Common.Models.Responses.Label.LabelTranslation;

namespace Translation.Common.Contracts
{
    public interface ILabelService
    {
        Task<LabelCreateResponse> CreateLabel(LabelCreateRequest request);
        Task<LabelCreateListResponse> CreateLabelFromList(LabelCreateListRequest request);
        Task<LabelReadResponse> GetLabel(LabelReadRequest request);
        Task<LabelReadListResponse> GetLabels(LabelReadListRequest request);
        Task<LabelEditResponse> EditLabel(LabelEditRequest request);
        Task<LabelDeleteResponse> DeleteLabel(LabelDeleteRequest request);
        Task<LabelChangeActivationResponse> ChangeActivation(LabelChangeActivationRequest request);
        Task<LabelCloneResponse> CloneLabel(LabelCloneRequest request);

        Task<LabelTranslationCreateResponse> CreateTranslation(LabelTranslationCreateRequest request);
        Task<LabelTranslationCreateListResponse> CreateTranslationFromList(LabelTranslationCreateListRequest request);
        Task<LabelTranslationReadListResponse> GetTranslation(LabelTranslationReadRequest request);
        Task<LabelTranslationReadListResponse> GetTranslations(LabelTranslationReadListRequest request);
        Task<LabelTranslationEditResponse> EditTranslation(LabelTranslationEditRequest request);
        Task<LabelTranslationDeleteResponse> DeleteTranslation(LabelTranslationDeleteRequest request);
        
    }
}