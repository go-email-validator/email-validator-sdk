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
 * CheckIfEmailExistMisc
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-02-10T07:42:09.412Z[GMT]")
public class CheckIfEmailExistMisc {
  public static final String SERIALIZED_NAME_IS_DISPOSABLE = "is_disposable";
  @SerializedName(SERIALIZED_NAME_IS_DISPOSABLE)
  private Boolean isDisposable;

  public static final String SERIALIZED_NAME_IS_ROLE_ACCOUNT = "is_role_account";
  @SerializedName(SERIALIZED_NAME_IS_ROLE_ACCOUNT)
  private Boolean isRoleAccount;


  public CheckIfEmailExistMisc isDisposable(Boolean isDisposable) {
    
    this.isDisposable = isDisposable;
    return this;
  }

   /**
   * Get isDisposable
   * @return isDisposable
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsDisposable() {
    return isDisposable;
  }


  public void setIsDisposable(Boolean isDisposable) {
    this.isDisposable = isDisposable;
  }


  public CheckIfEmailExistMisc isRoleAccount(Boolean isRoleAccount) {
    
    this.isRoleAccount = isRoleAccount;
    return this;
  }

   /**
   * Get isRoleAccount
   * @return isRoleAccount
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getIsRoleAccount() {
    return isRoleAccount;
  }


  public void setIsRoleAccount(Boolean isRoleAccount) {
    this.isRoleAccount = isRoleAccount;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CheckIfEmailExistMisc checkIfEmailExistMisc = (CheckIfEmailExistMisc) o;
    return Objects.equals(this.isDisposable, checkIfEmailExistMisc.isDisposable) &&
        Objects.equals(this.isRoleAccount, checkIfEmailExistMisc.isRoleAccount);
  }

  @Override
  public int hashCode() {
    return Objects.hash(isDisposable, isRoleAccount);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CheckIfEmailExistMisc {\n");
    sb.append("    isDisposable: ").append(toIndentedString(isDisposable)).append("\n");
    sb.append("    isRoleAccount: ").append(toIndentedString(isRoleAccount)).append("\n");
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

