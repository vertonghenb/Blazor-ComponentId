using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System;

namespace Beerhall.Components
{
    public class MBaseComponent : BlazorComponent
    {
        #region Parameters
        protected virtual string DefaultClass { get; set; }
        [Parameter] protected string Class { get; set; }
        [Parameter] protected RenderFragment ChildContent { get; set; }
        [Parameter] protected EState State { get; set; } = EState.Secondary;
        [Parameter] protected ESize Size { get; set; } = ESize.Medium;
        [Parameter] protected Action OnClick { get; set; }
        #endregion

        #region Functions
        protected virtual string GetClass()
        {
            return $"{DefaultClass} {Class}";
        }
        #endregion
    }
}
