/*
 Navicat Premium Dump SQL

 Source Server         : KK
 Source Server Type    : MySQL
 Source Server Version : 80403 (8.4.3)
 Source Host           : localhost:3306
 Source Schema         : leshanticketsystem

 Target Server Type    : MySQL
 Target Server Version : 80403 (8.4.3)
 File Encoding         : 65001

 Date: 15/04/2025 00:01:42
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin`  (
  `id` int NOT NULL AUTO_INCREMENT COMMENT '主键',
  `uid` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '管理员唯一ID',
  `password` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '登录密码（建议加密）',
  `phone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '联系电话',
  `sex` enum('男','女','保密') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT '保密' COMMENT '性别',
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `uid`(`uid` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci COMMENT = '管理员信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES (1, '5150626', '1111', '55555555555', '保密');

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `id` int UNSIGNED NOT NULL,
  `order_id` int NOT NULL COMMENT '业务订单号（唯一）',
  `name` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '游客姓名',
  `price` decimal(10, 0) NOT NULL COMMENT '订单金额',
  `id_card` char(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '身份证号',
  `phone` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '手机号',
  `sex` enum('男','女') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '性别',
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `uk_order_id`(`order_id` ASC) USING BTREE,
  UNIQUE INDEX `uk_id_card`(`id_card` ASC) USING BTREE,
  INDEX `idx_phone`(`phone` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci COMMENT = '乐山大佛票务订单表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO `orders` VALUES (1, 2025411, 'lhj', 80, '123456', '15541204561', '男');
INSERT INTO `orders` VALUES (2, 2025412, 'zs', 80, '50038', '19961155706', '男');

-- ----------------------------
-- Table structure for ticket
-- ----------------------------
DROP TABLE IF EXISTS `ticket`;
CREATE TABLE `ticket`  (
  `order_id` int UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '关联的订单编号',
  `ticket_type` enum('成人票','儿童票') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '门票类型',
  `remaining_quantity` int UNSIGNED NOT NULL DEFAULT 0 COMMENT '剩余可用数量',
  `price` decimal(10, 2) NOT NULL COMMENT '单张门票价格',
  PRIMARY KEY (`order_id`, `ticket_type`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci COMMENT = '门票数量表' ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of ticket
-- ----------------------------
INSERT INTO `ticket` VALUES (1, '成人票', 600, 180.00);
INSERT INTO `ticket` VALUES (2, '儿童票', 100, 90.00);

-- ----------------------------
-- Table structure for ticket_sales
-- ----------------------------
DROP TABLE IF EXISTS `ticket_sales`;
CREATE TABLE `ticket_sales`  (
  `sale_date` date NOT NULL DEFAULT (curdate()),
  `adult_tickets` int NOT NULL DEFAULT 0,
  `child_tickets` int NOT NULL DEFAULT 0,
  `total_amount` decimal(10, 2) GENERATED ALWAYS AS (((`adult_tickets` * 80) + (`child_tickets` * 40))) STORED NULL,
  PRIMARY KEY (`sale_date`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of ticket_sales
-- ----------------------------
INSERT INTO `ticket_sales` VALUES ('2025-04-11', 10, 5, DEFAULT);
INSERT INTO `ticket_sales` VALUES ('2025-04-12', 20, 20, DEFAULT);
INSERT INTO `ticket_sales` VALUES ('2025-04-13', 8, 10, DEFAULT);
INSERT INTO `ticket_sales` VALUES ('2025-04-14', 7, 10, DEFAULT);
INSERT INTO `ticket_sales` VALUES ('2025-04-15', 12, 14, DEFAULT);
INSERT INTO `ticket_sales` VALUES ('2025-04-16', 22, 18, DEFAULT);

-- ----------------------------
-- Table structure for tourist
-- ----------------------------
DROP TABLE IF EXISTS `tourist`;
CREATE TABLE `tourist`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `sex` enum('男','女') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `phone` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `id_card` varchar(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `status` tinyint(1) NULL DEFAULT 0,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `id_card`(`id_card` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tourist
-- ----------------------------
INSERT INTO `tourist` VALUES (1, '张三', '男', '13800138001', '510103199003022345', 0);
INSERT INTO `tourist` VALUES (2, '李四', '女', '13900139002', '510104199503022345', 0);

-- ----------------------------
-- Triggers structure for table orders
-- ----------------------------
DROP TRIGGER IF EXISTS `before_insert_orders_id_fix`;
delimiter ;;
CREATE TRIGGER `before_insert_orders_id_fix` BEFORE INSERT ON `orders` FOR EACH ROW BEGIN
  DECLARE max_id INT;

  -- 如果插入时没有显式指定 id，则自动设置为最大 id + 1
  IF NEW.id IS NULL OR NEW.id = 0 THEN
    SELECT IFNULL(MAX(id), 0) INTO max_id FROM orders;
    SET NEW.id = max_id + 1;
  END IF;
END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
