/**
 * Email Validator
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';
/**
* Enum class ResultType.
* @enum {}
* @readonly
*/
export default class ResultType {
    
        /**
         * value: "CHECK_IF_EMAIL_EXIST"
         * @const
         */
        "CHECK_IF_EMAIL_EXIST" = "CHECK_IF_EMAIL_EXIST";

    
        /**
         * value: "CIEE"
         * @const
         */
        "CIEE" = "CIEE";

    
        /**
         * value: "MAILBOXVALIDATOR"
         * @const
         */
        "MAILBOXVALIDATOR" = "MAILBOXVALIDATOR";

    
        /**
         * value: "MAIL_BOX_VALIDATOR"
         * @const
         */
        "MAIL_BOX_VALIDATOR" = "MAIL_BOX_VALIDATOR";

    
        /**
         * value: "MBV"
         * @const
         */
        "MBV" = "MBV";

    
        /**
         * value: "PROMPT_EMAIL_VERIFICATION_API"
         * @const
         */
        "PROMPT_EMAIL_VERIFICATION_API" = "PROMPT_EMAIL_VERIFICATION_API";

    
        /**
         * value: "PEVA"
         * @const
         */
        "PEVA" = "PEVA";

    

    /**
    * Returns a <code>ResultType</code> enum value from a Javascript object name.
    * @param {Object} data The plain JavaScript object containing the name of the enum value.
    * @return {module:model/ResultType} The enum <code>ResultType</code> value.
    */
    static constructFromObject(object) {
        return object;
    }
}

