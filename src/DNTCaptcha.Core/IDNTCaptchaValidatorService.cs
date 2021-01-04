namespace DNTCaptcha.Core
{
    /// <summary>
    /// Validates the input number.
    /// </summary>
    public interface IDNTCaptchaValidatorService
    {
        /// <summary>
        /// Validates the input number.
        /// </summary>
        /// <param name="captchaGeneratorLanguage">The Number to word language.</param>
        /// <param name="captchaGeneratorDisplayMode">Display mode of the captcha's text.</param>
        bool HasRequestValidCaptchaEntry(Language captchaGeneratorLanguage, DisplayMode captchaGeneratorDisplayMode);

        /// <summary>
        /// Validates the input
        /// </summary>
        /// <param name="captchaGeneratorLanguage"></param>
        /// <param name="captchaGeneratorDisplayMode"></param>
        /// <param name="inputText"></param>
        /// <param name="captchaText"></param>
        /// <returns></returns>
        bool HasValidCaptchaEntry(Language captchaGeneratorLanguage, DisplayMode captchaGeneratorDisplayMode, string inputText, string captchaText);
    }
}