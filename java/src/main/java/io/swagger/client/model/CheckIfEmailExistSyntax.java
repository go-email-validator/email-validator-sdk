/*
 * Email Validator
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * OpenAPI spec version: 0.0.1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * CheckIfEmailExistSyntax
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2021-02-05T12:42:25.901Z[GMT]")
public class CheckIfEmailExistSyntax {
  @SerializedName("address")
  private String address = null;

  @SerializedName("domain")
  private String domain = null;

  @SerializedName("is_valid_syntax")
  private Boolean isValidSyntax = null;

  @SerializedName("username")
  private String username = null;

  public CheckIfEmailExistSyntax address(String address) {
    this.address = address;
    return this;
  }

   /**
   * Get address
   * @return address
  **/
  @Schema(description = "")
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
  @Schema(description = "")
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
  @Schema(description = "")
  public Boolean isIsValidSyntax() {
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
  @Schema(description = "")
  public String getUsername() {
    return username;
  }

  public void setUsername(String username) {
    this.username = username;
  }


  @Override
  public boolean equals(java.lang.Object o) {
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
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
