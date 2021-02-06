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
import CheckIfEmailExistMX from './CheckIfEmailExistMX';
import CheckIfEmailExistMisc from './CheckIfEmailExistMisc';
import CheckIfEmailExistSMTP from './CheckIfEmailExistSMTP';
import CheckIfEmailExistSyntax from './CheckIfEmailExistSyntax';

/**
 * The CheckIfEmailExistResult model module.
 * @module model/CheckIfEmailExistResult
 * @version 0.0.1
 */
class CheckIfEmailExistResult {
    /**
     * Constructs a new <code>CheckIfEmailExistResult</code>.
     * @alias module:model/CheckIfEmailExistResult
     */
    constructor() { 
        
        CheckIfEmailExistResult.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>CheckIfEmailExistResult</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/CheckIfEmailExistResult} obj Optional instance to populate.
     * @return {module:model/CheckIfEmailExistResult} The populated <code>CheckIfEmailExistResult</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new CheckIfEmailExistResult();

            if (data.hasOwnProperty('input')) {
                obj['input'] = ApiClient.convertToType(data['input'], 'String');
            }
            if (data.hasOwnProperty('is_reachable')) {
                obj['is_reachable'] = ApiClient.convertToType(data['is_reachable'], 'String');
            }
            if (data.hasOwnProperty('misc')) {
                obj['misc'] = CheckIfEmailExistMisc.constructFromObject(data['misc']);
            }
            if (data.hasOwnProperty('mx')) {
                obj['mx'] = CheckIfEmailExistMX.constructFromObject(data['mx']);
            }
            if (data.hasOwnProperty('smtp')) {
                obj['smtp'] = CheckIfEmailExistSMTP.constructFromObject(data['smtp']);
            }
            if (data.hasOwnProperty('syntax')) {
                obj['syntax'] = CheckIfEmailExistSyntax.constructFromObject(data['syntax']);
            }
            if (data.hasOwnProperty('error')) {
                obj['error'] = ApiClient.convertToType(data['error'], 'String');
            }
        }
        return obj;
    }


}

/**
 * @member {String} input
 */
CheckIfEmailExistResult.prototype['input'] = undefined;

/**
 * @member {String} is_reachable
 */
CheckIfEmailExistResult.prototype['is_reachable'] = undefined;

/**
 * @member {module:model/CheckIfEmailExistMisc} misc
 */
CheckIfEmailExistResult.prototype['misc'] = undefined;

/**
 * @member {module:model/CheckIfEmailExistMX} mx
 */
CheckIfEmailExistResult.prototype['mx'] = undefined;

/**
 * @member {module:model/CheckIfEmailExistSMTP} smtp
 */
CheckIfEmailExistResult.prototype['smtp'] = undefined;

/**
 * @member {module:model/CheckIfEmailExistSyntax} syntax
 */
CheckIfEmailExistResult.prototype['syntax'] = undefined;

/**
 * @member {String} error
 */
CheckIfEmailExistResult.prototype['error'] = undefined;






export default CheckIfEmailExistResult;

