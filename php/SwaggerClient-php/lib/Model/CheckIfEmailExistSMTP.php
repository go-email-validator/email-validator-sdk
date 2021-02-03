<?php
/**
 * CheckIfEmailExistSMTP
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
 * CheckIfEmailExistSMTP Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CheckIfEmailExistSMTP implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'CheckIfEmailExistSMTP';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'can_connect_smtp' => 'bool',
'has_full_inbox' => 'bool',
'is_catch_all' => 'bool',
'is_deliverable' => 'bool',
'is_disabled' => 'bool'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'can_connect_smtp' => null,
'has_full_inbox' => null,
'is_catch_all' => null,
'is_deliverable' => null,
'is_disabled' => null    ];

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
        'can_connect_smtp' => 'can_connect_smtp',
'has_full_inbox' => 'has_full_inbox',
'is_catch_all' => 'is_catch_all',
'is_deliverable' => 'is_deliverable',
'is_disabled' => 'is_disabled'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'can_connect_smtp' => 'setCanConnectSmtp',
'has_full_inbox' => 'setHasFullInbox',
'is_catch_all' => 'setIsCatchAll',
'is_deliverable' => 'setIsDeliverable',
'is_disabled' => 'setIsDisabled'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'can_connect_smtp' => 'getCanConnectSmtp',
'has_full_inbox' => 'getHasFullInbox',
'is_catch_all' => 'getIsCatchAll',
'is_deliverable' => 'getIsDeliverable',
'is_disabled' => 'getIsDisabled'    ];

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
        $this->container['can_connect_smtp'] = isset($data['can_connect_smtp']) ? $data['can_connect_smtp'] : null;
        $this->container['has_full_inbox'] = isset($data['has_full_inbox']) ? $data['has_full_inbox'] : null;
        $this->container['is_catch_all'] = isset($data['is_catch_all']) ? $data['is_catch_all'] : null;
        $this->container['is_deliverable'] = isset($data['is_deliverable']) ? $data['is_deliverable'] : null;
        $this->container['is_disabled'] = isset($data['is_disabled']) ? $data['is_disabled'] : null;
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
     * Gets can_connect_smtp
     *
     * @return bool
     */
    public function getCanConnectSmtp()
    {
        return $this->container['can_connect_smtp'];
    }

    /**
     * Sets can_connect_smtp
     *
     * @param bool $can_connect_smtp can_connect_smtp
     *
     * @return $this
     */
    public function setCanConnectSmtp($can_connect_smtp)
    {
        $this->container['can_connect_smtp'] = $can_connect_smtp;

        return $this;
    }

    /**
     * Gets has_full_inbox
     *
     * @return bool
     */
    public function getHasFullInbox()
    {
        return $this->container['has_full_inbox'];
    }

    /**
     * Sets has_full_inbox
     *
     * @param bool $has_full_inbox has_full_inbox
     *
     * @return $this
     */
    public function setHasFullInbox($has_full_inbox)
    {
        $this->container['has_full_inbox'] = $has_full_inbox;

        return $this;
    }

    /**
     * Gets is_catch_all
     *
     * @return bool
     */
    public function getIsCatchAll()
    {
        return $this->container['is_catch_all'];
    }

    /**
     * Sets is_catch_all
     *
     * @param bool $is_catch_all is_catch_all
     *
     * @return $this
     */
    public function setIsCatchAll($is_catch_all)
    {
        $this->container['is_catch_all'] = $is_catch_all;

        return $this;
    }

    /**
     * Gets is_deliverable
     *
     * @return bool
     */
    public function getIsDeliverable()
    {
        return $this->container['is_deliverable'];
    }

    /**
     * Sets is_deliverable
     *
     * @param bool $is_deliverable is_deliverable
     *
     * @return $this
     */
    public function setIsDeliverable($is_deliverable)
    {
        $this->container['is_deliverable'] = $is_deliverable;

        return $this;
    }

    /**
     * Gets is_disabled
     *
     * @return bool
     */
    public function getIsDisabled()
    {
        return $this->container['is_disabled'];
    }

    /**
     * Sets is_disabled
     *
     * @param bool $is_disabled is_disabled
     *
     * @return $this
     */
    public function setIsDisabled($is_disabled)
    {
        $this->container['is_disabled'] = $is_disabled;

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