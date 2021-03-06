/*
 * Email Validator
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * CheckIfEmailExistSyntax
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-02-10T07:42:09.412Z[GMT]")
public class CheckIfEmailExistSyntax {
  public static final String SERIALIZED_NAME_ADDRESS = "address";
  @SerializedName(SERIALIZED_NAME_ADDRESS)
  private String address;

  public static final String SERIALIZED_NAME_DOMAIN = "domain";
  @SerializedName(SERIALIZED_NAME_DOMAIN)
  private String domain;

  public static final String SERIALIZED_NAME_IS_VALID_SYNTAX = "is_valid_syntax";
  @SerializedName(SERIALIZED_NAME_IS_VALID_SYNTAX)
  private Boolean isValidSyntax;

  public static final String SERIALIZED_NAME_USERNAME = "username";
  @SerializedName(SERIALIZED_NAME_USERNAME)
  private String username;


  public CheckIfEmailExistSyntax address(String address) {
    
    this.address = address;
    return this;
  }

   /**
   * Get address
   * @return address
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getAddress() {
    return address;
  }


  public void setAddress(String address) {
    this.address = address;
  }


  public CheckIfEmailExistSyntax domain(String domain) {
    
    this.domain = domain;
    return this;
  }

   /**
   * Get domain
   * @return domain
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getDomain() {
    return domain;
  }


  public void setDomain(String domain) {
    this.domain = domain;
  }


  public CheckIfEmailExistSyntax isValidSyntax(Boolean isValidSyntax) {
    
    this.isValidSyntax = isValidSyntax;
    return this;
  }

   /**
   * Get isValidSyntax
   * @return isValidSyntax
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsValidSyntax() {
    return isValidSyntax;
  }


  public void setIsValidSyntax(Boolean isValidSyntax) {
    this.isValidSyntax = isValidSyntax;
  }


  public CheckIfEmailExistSyntax username(String username) {
    
    this.username = username;
    return this;
  }

   /**
   * Get username
   * @return username
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getUsername() {
    return username;
  }


  public void setUsername(String username) {
    this.username = username;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CheckIfEmailExistSyntax checkIfEmailExistSyntax = (CheckIfEmailExistSyntax) o;
    return Objects.equals(this.address, checkIfEmailExistSyntax.address) &&
        Objects.equals(this.domain, checkIfEmailExistSyntax.domain) &&
        Objects.equals(this.isValidSyntax, checkIfEmailExistSyntax.isValidSyntax) &&
        Objects.equals(this.username, checkIfEmailExistSyntax.username);
  }

  @Override
  public int hashCode() {
    return Objects.hash(address, domain, isValidSyntax, username);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CheckIfEmailExistSyntax {\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    domain: ").append(toIndentedString(domain)).append("\n");
    sb.append("    isValidSyntax: ").append(toIndentedString(isValidSyntax)).append("\n");
    sb.append("    username: ").append(toIndentedString(username)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

