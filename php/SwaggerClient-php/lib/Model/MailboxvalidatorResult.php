<?php
/**
 * MailboxvalidatorResult
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Email Validator
 *
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds.
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.24
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * MailboxvalidatorResult Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class MailboxvalidatorResult implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'MailboxvalidatorResult';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'email_address' => 'string',
'domain' => 'string',
'is_free' => 'string',
'is_syntax' => 'string',
'is_domain' => 'string',
'is_smtp' => 'string',
'is_verified' => 'string',
'is_server_down' => 'string',
'is_greylisted' => 'string',
'is_disposable' => 'string',
'is_suppressed' => 'string',
'is_role' => 'string',
'is_high_risk' => 'string',
'is_catchall' => 'string',
'mailboxvalidator_score' => 'string',
'time_taken' => 'string',
'status' => 'string',
'credits_available' => 'int',
'error_code' => 'string',
'error_message' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'email_address' => null,
'domain' => null,
'is_free' => null,
'is_syntax' => null,
'is_domain' => null,
'is_smtp' => null,
'is_verified' => null,
'is_server_down' => null,
'is_greylisted' => null,
'is_disposable' => null,
'is_suppressed' => null,
'is_role' => null,
'is_high_risk' => null,
'is_catchall' => null,
'mailboxvalidator_score' => null,
'time_taken' => null,
'status' => null,
'credits_available' => 'int64',
'error_code' => null,
'error_message' => null    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'email_address' => 'email_address',
'domain' => 'domain',
'is_free' => 'is_free',
'is_syntax' => 'is_syntax',
'is_domain' => 'is_domain',
'is_smtp' => 'is_smtp',
'is_verified' => 'is_verified',
'is_server_down' => 'is_server_down',
'is_greylisted' => 'is_greylisted',
'is_disposable' => 'is_disposable',
'is_suppressed' => 'is_suppressed',
'is_role' => 'is_role',
'is_high_risk' => 'is_high_risk',
'is_catchall' => 'is_catchall',
'mailboxvalidator_score' => 'mailboxvalidator_score',
'time_taken' => 'time_taken',
'status' => 'status',
'credits_available' => 'credits_available',
'error_code' => 'error_code',
'error_message' => 'error_message'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'email_address' => 'setEmailAddress',
'domain' => 'setDomain',
'is_free' => 'setIsFree',
'is_syntax' => 'setIsSyntax',
'is_domain' => 'setIsDomain',
'is_smtp' => 'setIsSmtp',
'is_verified' => 'setIsVerified',
'is_server_down' => 'setIsServerDown',
'is_greylisted' => 'setIsGreylisted',
'is_disposable' => 'setIsDisposable',
'is_suppressed' => 'setIsSuppressed',
'is_role' => 'setIsRole',
'is_high_risk' => 'setIsHighRisk',
'is_catchall' => 'setIsCatchall',
'mailboxvalidator_score' => 'setMailboxvalidatorScore',
'time_taken' => 'setTimeTaken',
'status' => 'setStatus',
'credits_available' => 'setCreditsAvailable',
'error_code' => 'setErrorCode',
'error_message' => 'setErrorMessage'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'email_address' => 'getEmailAddress',
'domain' => 'getDomain',
'is_free' => 'getIsFree',
'is_syntax' => 'getIsSyntax',
'is_domain' => 'getIsDomain',
'is_smtp' => 'getIsSmtp',
'is_verified' => 'getIsVerified',
'is_server_down' => 'getIsServerDown',
'is_greylisted' => 'getIsGreylisted',
'is_disposable' => 'getIsDisposable',
'is_suppressed' => 'getIsSuppressed',
'is_role' => 'getIsRole',
'is_high_risk' => 'getIsHighRisk',
'is_catchall' => 'getIsCatchall',
'mailboxvalidator_score' => 'getMailboxvalidatorScore',
'time_taken' => 'getTimeTaken',
'status' => 'getStatus',
'credits_available' => 'getCreditsAvailable',
'error_code' => 'getErrorCode',
'error_message' => 'getErrorMessage'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['email_address'] = isset($data['email_address']) ? $data['email_address'] : null;
        $this->container['domain'] = isset($data['domain']) ? $data['domain'] : null;
        $this->container['is_free'] = isset($data['is_free']) ? $data['is_free'] : null;
        $this->container['is_syntax'] = isset($data['is_syntax']) ? $data['is_syntax'] : null;
        $this->container['is_domain'] = isset($data['is_domain']) ? $data['is_domain'] : null;
        $this->container['is_smtp'] = isset($data['is_smtp']) ? $data['is_smtp'] : null;
        $this->container['is_verified'] = isset($data['is_verified']) ? $data['is_verified'] : null;
        $this->container['is_server_down'] = isset($data['is_server_down']) ? $data['is_server_down'] : null;
        $this->container['is_greylisted'] = isset($data['is_greylisted']) ? $data['is_greylisted'] : null;
        $this->container['is_disposable'] = isset($data['is_disposable']) ? $data['is_disposable'] : null;
        $this->container['is_suppressed'] = isset($data['is_suppressed']) ? $data['is_suppressed'] : null;
        $this->container['is_role'] = isset($data['is_role']) ? $data['is_role'] : null;
        $this->container['is_high_risk'] = isset($data['is_high_risk']) ? $data['is_high_risk'] : null;
        $this->container['is_catchall'] = isset($data['is_catchall']) ? $data['is_catchall'] : null;
        $this->container['mailboxvalidator_score'] = isset($data['mailboxvalidator_score']) ? $data['mailboxvalidator_score'] : null;
        $this->container['time_taken'] = isset($data['time_taken']) ? $data['time_taken'] : null;
        $this->container['status'] = isset($data['status']) ? $data['status'] : null;
        $this->container['credits_available'] = isset($data['credits_available']) ? $data['credits_available'] : null;
        $this->container['error_code'] = isset($data['error_code']) ? $data['error_code'] : null;
        $this->container['error_message'] = isset($data['error_message']) ? $data['error_message'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets email_address
     *
     * @return string
     */
    public function getEmailAddress()
    {
        return $this->container['email_address'];
    }

    /**
     * Sets email_address
     *
     * @param string $email_address email_address
     *
     * @return $this
     */
    public function setEmailAddress($email_address)
    {
        $this->container['email_address'] = $email_address;

        return $this;
    }

    /**
     * Gets domain
     *
     * @return string
     */
    public function getDomain()
    {
        return $this->container['domain'];
    }

    /**
     * Sets domain
     *
     * @param string $domain domain
     *
     * @return $this
     */
    public function setDomain($domain)
    {
        $this->container['domain'] = $domain;

        return $this;
    }

    /**
     * Gets is_free
     *
     * @return string
     */
    public function getIsFree()
    {
        return $this->container['is_free'];
    }

    /**
     * Sets is_free
     *
     * @param string $is_free is_free
     *
     * @return $this
     */
    public function setIsFree($is_free)
    {
        $this->container['is_free'] = $is_free;

        return $this;
    }

    /**
     * Gets is_syntax
     *
     * @return string
     */
    public function getIsSyntax()
    {
        return $this->container['is_syntax'];
    }

    /**
     * Sets is_syntax
     *
     * @param string $is_syntax is_syntax
     *
     * @return $this
     */
    public function setIsSyntax($is_syntax)
    {
        $this->container['is_syntax'] = $is_syntax;

        return $this;
    }

    /**
     * Gets is_domain
     *
     * @return string
     */
    public function getIsDomain()
    {
        return $this->container['is_domain'];
    }

    /**
     * Sets is_domain
     *
     * @param string $is_domain is_domain
     *
     * @return $this
     */
    public function setIsDomain($is_domain)
    {
        $this->container['is_domain'] = $is_domain;

        return $this;
    }

    /**
     * Gets is_smtp
     *
     * @return string
     */
    public function getIsSmtp()
    {
        return $this->container['is_smtp'];
    }

    /**
     * Sets is_smtp
     *
     * @param string $is_smtp is_smtp
     *
     * @return $this
     */
    public function setIsSmtp($is_smtp)
    {
        $this->container['is_smtp'] = $is_smtp;

        return $this;
    }

    /**
     * Gets is_verified
     *
     * @return string
     */
    public function getIsVerified()
    {
        return $this->container['is_verified'];
    }

    /**
     * Sets is_verified
     *
     * @param string $is_verified is_verified
     *
     * @return $this
     */
    public function setIsVerified($is_verified)
    {
        $this->container['is_verified'] = $is_verified;

        return $this;
    }

    /**
     * Gets is_server_down
     *
     * @return string
     */
    public function getIsServerDown()
    {
        return $this->container['is_server_down'];
    }

    /**
     * Sets is_server_down
     *
     * @param string $is_server_down is_server_down
     *
     * @return $this
     */
    public function setIsServerDown($is_server_down)
    {
        $this->container['is_server_down'] = $is_server_down;

        return $this;
    }

    /**
     * Gets is_greylisted
     *
     * @return string
     */
    public function getIsGreylisted()
    {
        return $this->container['is_greylisted'];
    }

    /**
     * Sets is_greylisted
     *
     * @param string $is_greylisted is_greylisted
     *
     * @return $this
     */
    public function setIsGreylisted($is_greylisted)
    {
        $this->container['is_greylisted'] = $is_greylisted;

        return $this;
    }

    /**
     * Gets is_disposable
     *
     * @return string
     */
    public function getIsDisposable()
    {
        return $this->container['is_disposable'];
    }

    /**
     * Sets is_disposable
     *
     * @param string $is_disposable is_disposable
     *
     * @return $this
     */
    public function setIsDisposable($is_disposable)
    {
        $this->container['is_disposable'] = $is_disposable;

        return $this;
    }

    /**
     * Gets is_suppressed
     *
     * @return string
     */
    public function getIsSuppressed()
    {
        return $this->container['is_suppressed'];
    }

    /**
     * Sets is_suppressed
     *
     * @param string $is_suppressed is_suppressed
     *
     * @return $this
     */
    public function setIsSuppressed($is_suppressed)
    {
        $this->container['is_suppressed'] = $is_suppressed;

        return $this;
    }

    /**
     * Gets is_role
     *
     * @return string
     */
    public function getIsRole()
    {
        return $this->container['is_role'];
    }

    /**
     * Sets is_role
     *
     * @param string $is_role is_role
     *
     * @return $this
     */
    public function setIsRole($is_role)
    {
        $this->container['is_role'] = $is_role;

        return $this;
    }

    /**
     * Gets is_high_risk
     *
     * @return string
     */
    public function getIsHighRisk()
    {
        return $this->container['is_high_risk'];
    }

    /**
     * Sets is_high_risk
     *
     * @param string $is_high_risk is_high_risk
     *
     * @return $this
     */
    public function setIsHighRisk($is_high_risk)
    {
        $this->container['is_high_risk'] = $is_high_risk;

        return $this;
    }

    /**
     * Gets is_catchall
     *
     * @return string
     */
    public function getIsCatchall()
    {
        return $this->container['is_catchall'];
    }

    /**
     * Sets is_catchall
     *
     * @param string $is_catchall is_catchall
     *
     * @return $this
     */
    public function setIsCatchall($is_catchall)
    {
        $this->container['is_catchall'] = $is_catchall;

        return $this;
    }

    /**
     * Gets mailboxvalidator_score
     *
     * @return string
     */
    public function getMailboxvalidatorScore()
    {
        return $this->container['mailboxvalidator_score'];
    }

    /**
     * Sets mailboxvalidator_score
     *
     * @param string $mailboxvalidator_score mailboxvalidator_score
     *
     * @return $this
     */
    public function setMailboxvalidatorScore($mailboxvalidator_score)
    {
        $this->container['mailboxvalidator_score'] = $mailboxvalidator_score;

        return $this;
    }

    /**
     * Gets time_taken
     *
     * @return string
     */
    public function getTimeTaken()
    {
        return $this->container['time_taken'];
    }

    /**
     * Sets time_taken
     *
     * @param string $time_taken time_taken
     *
     * @return $this
     */
    public function setTimeTaken($time_taken)
    {
        $this->container['time_taken'] = $time_taken;

        return $this;
    }

    /**
     * Gets status
     *
     * @return string
     */
    public function getStatus()
    {
        return $this->container['status'];
    }

    /**
     * Sets status
     *
     * @param string $status status
     *
     * @return $this
     */
    public function setStatus($status)
    {
        $this->container['status'] = $status;

        return $this;
    }

    /**
     * Gets credits_available
     *
     * @return int
     */
    public function getCreditsAvailable()
    {
        return $this->container['credits_available'];
    }

    /**
     * Sets credits_available
     *
     * @param int $credits_available credits_available
     *
     * @return $this
     */
    public function setCreditsAvailable($credits_available)
    {
        $this->container['credits_available'] = $credits_available;

        return $this;
    }

    /**
     * Gets error_code
     *
     * @return string
     */
    public function getErrorCode()
    {
        return $this->container['error_code'];
    }

    /**
     * Sets error_code
     *
     * @param string $error_code error_code
     *
     * @return $this
     */
    public function setErrorCode($error_code)
    {
        $this->container['error_code'] = $error_code;

        return $this;
    }

    /**
     * Gets error_message
     *
     * @return string
     */
    public function getErrorMessage()
    {
        return $this->container['error_message'];
    }

    /**
     * Sets error_message
     *
     * @param string $error_message error_message
     *
     * @return $this
     */
    public function setErrorMessage($error_message)
    {
        $this->container['error_message'] = $error_message;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
