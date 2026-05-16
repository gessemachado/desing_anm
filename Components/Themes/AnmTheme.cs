using MudBlazor;

namespace desing_ANM.Components.Themes;

public static class AnmTheme
{
    public static MudTheme Create() => new()
    {
        PaletteLight = new PaletteLight
        {
            // Primária: Azul ANM
            Primary = "#0A527A",
            PrimaryLighten = "#5BA3C9",
            PrimaryDarken = "#063A57",
            PrimaryContrastText = "#FFFFFF",

            // Secundária: Verde
            Secondary = "#178058",
            SecondaryLighten = "#3BBB8F",
            SecondaryDarken = "#0F5A3D",
            SecondaryContrastText = "#FFFFFF",

            // Destaque: Amarelo
            Tertiary = "#FFC923",
            TertiaryContrastText = "#1A1A1A",

            // Superfícies
            Background = "#F5F7FA",
            Surface = "#FFFFFF",
            DrawerBackground = "#FFFFFF",
            AppbarBackground = "#0A527A",
            AppbarText = "#FFFFFF",

            // Texto
            TextPrimary = "#1A2B3C",
            TextSecondary = "#4A6070",
            TextDisabled = "#9EADB8",

            // Estado
            Success = "#178058",
            Warning = "#FFC923",
            Error = "#D32F2F",
            Info = "#5BA3C9",

            // Bordas e divisores
            LinesDefault = "#E0E8EF",
            Divider = "#E0E8EF",
            TableLines = "#E0E8EF",

            // Hover/seleção
            ActionDefault = "#0A527A",
            ActionDisabledBackground = "rgba(0,0,0,0.06)",
        },

        Typography = new Typography
        {
            Default = new DefaultTypography
            {
                FontFamily = ["Inter", "Roboto", "sans-serif"],
                FontSize = "1rem",
                FontWeight = "400",
                LineHeight = "1.5",
            },
            H1 = new H1Typography { FontSize = "3rem", FontWeight = "700", LineHeight = "1.2" },
            H2 = new H2Typography { FontSize = "2.25rem", FontWeight = "700", LineHeight = "1.25" },
            H3 = new H3Typography { FontSize = "1.875rem", FontWeight = "600", LineHeight = "1.3" },
            H4 = new H4Typography { FontSize = "1.5rem", FontWeight = "600", LineHeight = "1.35" },
            H5 = new H5Typography { FontSize = "1.25rem", FontWeight = "600", LineHeight = "1.4" },
            H6 = new H6Typography { FontSize = "1.125rem", FontWeight = "600", LineHeight = "1.4" },
            Body1 = new Body1Typography { FontSize = "1rem", FontWeight = "400", LineHeight = "1.5" },
            Body2 = new Body2Typography { FontSize = "0.875rem", FontWeight = "400", LineHeight = "1.43" },
            Caption = new CaptionTypography { FontSize = "0.75rem", FontWeight = "400", LineHeight = "1.4" },
            Button = new ButtonTypography { FontSize = "0.875rem", FontWeight = "600", TextTransform = "none" },
        },

        LayoutProperties = new LayoutProperties
        {
            DefaultBorderRadius = "6px",
        },
    };
}
