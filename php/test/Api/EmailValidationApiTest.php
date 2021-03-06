<?php
/**
 * EmailValidationApiTest
 * PHP version 5.6
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Email Validator
 *
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds.
 *
 * The version of the OpenAPI document: 0.0.1
 *
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.0.1-SNAPSHOT
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Please update the test case below to test the endpoint.
 */

namespace OpenAPI\Client\Test\Api;

use Dotenv\Dotenv;
use OpenAPI\Client\Api\EmailValidationApi;
use OpenAPI\Client\Configuration;
use PHPUnit\Framework\TestCase;

/**
 * EmailValidationApiTest Class Doc Comment
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class EmailValidationApiTest extends TestCase
{
    /** @var EmailValidationApi */
    protected $api;

    /**
     * Setup before running each test case
     */
    public function setUp(): void
    {
        $dotenv = Dotenv::createImmutable(__DIR__ . '/../../../');
        $c = $dotenv->load();

        $config = new Configuration();
        $config->setHost($_ENV['HOST']);
        $config->setApiKey(
            'X-RapidAPI-Key',
            $_ENV['API_KEY']
        );
        $this->api = new EmailValidationApi(null, $config);
    }

    /**
     * Test case for emailValidationSingleValidationGet
     *
     *
     */
    public function testEmailValidationSingleValidationGet()
    {
        $email = $_ENV["EMAIL"];
        $result = $this->api->emailValidationSingleValidationGet($email);

        $this->assertEquals($result->getCheckIfEmailExist()->getInput(), $email);
    }

    /**
     * Test case for emailValidationSingleValidationPost
     *
     * .
     *
     */
    public function testEmailValidationSingleValidationPost()
    {
        // TODO: implement
        $this->markTestIncomplete('Not implemented');
    }
}
