namespace Beerhall.Components


{
    /// <summary>
    /// The type attribute specifies the type of <input> element to display.
    /// </summary>
    /// <see cref="https://www.w3schools.com/tags/att_input_type.asp"/>
    public class EInputType
    {
        /// <summary>
        /// Defines a clickable button (mostly used with a JavaScript to activate a script)
        /// </summary>
        public static EInputType Button { get; } = new EInputType(0, "button");
        /// <summary>
        /// Defines a checkbox
        /// </summary>
        public static EInputType Checkbox { get; } = new EInputType(1, "checkbox");
        /// <summary>
        /// Defines a color picker
        /// </summary>
        public static EInputType Color { get; } = new EInputType(2, "color");
        /// <summary>
        /// Defines a date control (year, month, day (no time))
        /// </summary>
        public static EInputType Date { get; } = new EInputType(3, "date");
        /// <summary>
        /// Defines a date and time control (year, month, day, time (no time zone)
        /// </summary>
        public static EInputType Datetime_Local { get; } = new EInputType(4, "datetime-local");
        /// <summary>
        /// Defines a field for an e-mail address
        /// </summary>
        public static EInputType Email { get; } = new EInputType(5, "email");
        /// <summary>
        /// Defines a file-select field and a "Browse" button (for file uploads)
        /// </summary>
        public static EInputType File { get; } = new EInputType(6, "file");
        /// <summary>
        /// Defines a hidden input field
        /// </summary>
        public static EInputType Hidden { get; } = new EInputType(7, "hidden");
        /// <summary>
        /// Defines an image as the submit button
        /// </summary>
        public static EInputType Image { get; } = new EInputType(8, "image");
        /// <summary>
        /// Defines a month and year control (no time zone)
        /// </summary>
        public static EInputType Month { get; } = new EInputType(9, "month");
        /// <summary>
        /// Defines a field for entering a number
        /// </summary>
        public static EInputType Number { get; } = new EInputType(10, "number");
        /// <summary>
        /// Defines a password field (characters are masked)
        /// </summary>
        public static EInputType Password { get; } = new EInputType(11, "password");
        /// <summary>
        /// Defines a radio button
        /// </summary>
        public static EInputType Radio { get; } = new EInputType(12, "radio");
        /// <summary>
        /// Defines a control for entering a number whose exact value is not important (like a slider control). Default range is from 0 to 100
        /// </summary>
        public static EInputType Range { get; } = new EInputType(13, "range");
        /// <summary>
        /// Defines a reset button (resets all form values to default values)
        /// </summary>
        public static EInputType Reset { get; } = new EInputType(14, "reset");
        /// <summary>
        /// Defines a text field for entering a search string
        /// </summary>
        public static EInputType Search { get; } = new EInputType(15, "search");
        /// <summary>
        /// Defines a submit button
        /// </summary>
        public static EInputType Submit { get; } = new EInputType(16, "submit");
        /// <summary>
        /// Defines a field for entering a telephone number
        /// </summary>
        public static EInputType Telephone { get; } = new EInputType(17, "tel");
        /// <summary>
        /// Default. Defines a single-line text field (default width is 20 characters)
        /// </summary>
        public static EInputType Text { get; } = new EInputType(18, "text");
        /// <summary>
        /// Defines a control for entering a time (no time zone)
        /// </summary>
        public static EInputType Time { get; } = new EInputType(19, "time");
        /// <summary>
        /// Defines a field for entering a URL
        /// </summary>
        public static EInputType Url { get; } = new EInputType(20, "url");
        /// <summary>
        /// Defines a week and year control (no time zone)
        /// </summary>
        public static EInputType Week { get; } = new EInputType(21, "week");

        public string Name { get; private set; }
        public int Value { get; private set; }

        private EInputType(int val, string name)
        {
            Value = val;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
