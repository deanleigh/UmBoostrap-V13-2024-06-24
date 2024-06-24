//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.6.1+82eae48
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
    /// <summary>Feature - Rich Text Editor</summary>
    [PublishedModel("featureRichTextEditor")]
    public partial class FeatureRichTextEditor : PublishedElementModel, IFeatureComponentFeatureDescription, IFeatureComponentFeatureSummary, IFeatureComponentFeatureTitle, IFeatureComponentRichTextEditor
    {
        // helpers
#pragma warning disable 0109 // new is redundant
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public new const string ModelTypeAlias = "featureRichTextEditor";
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public new const PublishedItemType ModelItemType = PublishedItemType.Content;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
            => PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FeatureRichTextEditor, TValue>> selector)
            => PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

        private IPublishedValueFallback _publishedValueFallback;

        // ctor
        public FeatureRichTextEditor(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
            : base(content, publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;
        }

        // properties

        ///<summary>
        /// Description: Optional - Description for this feature
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        [ImplementPropertyType("featurePropertyFeatureDescription")]
        public virtual string FeaturePropertyFeatureDescription => global::Umbraco.Cms.Web.Common.PublishedModels.FeatureComponentFeatureDescription.GetFeaturePropertyFeatureDescription(this, _publishedValueFallback);

        ///<summary>
        /// Summary: Optional - Summary for this feature
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        [ImplementPropertyType("featurePropertyFeatureSummary")]
        public virtual string FeaturePropertyFeatureSummary => global::Umbraco.Cms.Web.Common.PublishedModels.FeatureComponentFeatureSummary.GetFeaturePropertyFeatureSummary(this, _publishedValueFallback);

        ///<summary>
        /// Title: Optional - Heading for this feature
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        [ImplementPropertyType("featurePropertyFeatureTitle")]
        public virtual string FeaturePropertyFeatureTitle => global::Umbraco.Cms.Web.Common.PublishedModels.FeatureComponentFeatureTitle.GetFeaturePropertyFeatureTitle(this, _publishedValueFallback);

        ///<summary>
        /// Rich Text
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        [ImplementPropertyType("richTextContent")]
        public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString RichTextContent => global::Umbraco.Cms.Web.Common.PublishedModels.FeatureComponentRichTextEditor.GetRichTextContent(this, _publishedValueFallback);
    }
}
