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
    // Mixin Content Type with alias "layoutSettingsComponentColorPicker"
    /// <summary>Layout Settings Component - Background Color</summary>
    public partial interface ILayoutSettingsComponentColorPicker : IPublishedElement
    {
        /// <summary>layoutAreasColourPicker</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor LayoutAreasColourPicker { get; }

        /// <summary>Opacity</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        decimal LayoutSettingsColourOpacity { get; }

        /// <summary>Colour</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor LayoutSettingsColourPicker { get; }

        /// <summary>Shade</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        decimal LayoutSettingsColourShades { get; }
    }

    /// <summary>Layout Settings Component - Background Color</summary>
    [PublishedModel("layoutSettingsComponentColorPicker")]
    public partial class LayoutSettingsComponentColorPicker : PublishedElementModel, ILayoutSettingsComponentColorPicker
    {
        // helpers
#pragma warning disable 0109 // new is redundant
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public new const string ModelTypeAlias = "layoutSettingsComponentColorPicker";
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public new const PublishedItemType ModelItemType = PublishedItemType.Content;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
            => PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<LayoutSettingsComponentColorPicker, TValue>> selector)
            => PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

        private IPublishedValueFallback _publishedValueFallback;

        // ctor
        public LayoutSettingsComponentColorPicker(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
            : base(content, publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;
        }

        // properties

        ///<summary>
        /// layoutAreasColourPicker
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        [ImplementPropertyType("layoutAreasColourPicker")]
        public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor LayoutAreasColourPicker => GetLayoutAreasColourPicker(this, _publishedValueFallback);

        /// <summary>Static getter for layoutAreasColourPicker</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public static global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor GetLayoutAreasColourPicker(ILayoutSettingsComponentColorPicker that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>(publishedValueFallback, "layoutAreasColourPicker");

        ///<summary>
        /// Opacity
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [ImplementPropertyType("layoutSettingsColourOpacity")]
        public virtual decimal LayoutSettingsColourOpacity => GetLayoutSettingsColourOpacity(this, _publishedValueFallback);

        /// <summary>Static getter for Opacity</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public static decimal GetLayoutSettingsColourOpacity(ILayoutSettingsComponentColorPicker that, IPublishedValueFallback publishedValueFallback) => that.Value<decimal>(publishedValueFallback, "layoutSettingsColourOpacity");

        ///<summary>
        /// Colour
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [global::System.Diagnostics.CodeAnalysis.MaybeNull]
        [ImplementPropertyType("layoutSettingsColourPicker")]
        public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor LayoutSettingsColourPicker => GetLayoutSettingsColourPicker(this, _publishedValueFallback);

        /// <summary>Static getter for Colour</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
        public static global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor GetLayoutSettingsColourPicker(ILayoutSettingsComponentColorPicker that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor>(publishedValueFallback, "layoutSettingsColourPicker");

        ///<summary>
        /// Shade
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        [ImplementPropertyType("layoutSettingsColourShades")]
        public virtual decimal LayoutSettingsColourShades => GetLayoutSettingsColourShades(this, _publishedValueFallback);

        /// <summary>Static getter for Shade</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
        public static decimal GetLayoutSettingsColourShades(ILayoutSettingsComponentColorPicker that, IPublishedValueFallback publishedValueFallback) => that.Value<decimal>(publishedValueFallback, "layoutSettingsColourShades");
    }
}
