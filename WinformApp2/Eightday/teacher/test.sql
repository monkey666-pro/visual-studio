/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50726
Source Host           : localhost:3306
Source Database       : test

Target Server Type    : MYSQL
Target Server Version : 50726
File Encoding         : 65001

Date: 2026-08-18 17:22:48
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for book
-- ----------------------------
DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL COMMENT '图书名称',
  `author` varchar(255) DEFAULT NULL COMMENT '作者',
  `price` double DEFAULT NULL COMMENT '图书价格',
  `label` varchar(255) DEFAULT NULL COMMENT '图书标签',
  `is_borrow` enum('2','1') DEFAULT '2' COMMENT '是否借阅',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of book
-- ----------------------------
INSERT INTO `book` VALUES ('1', '西游记', '吴承恩', '12', '神话\r | 古典', '2');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(255) DEFAULT NULL COMMENT '用户名',
  `password` varchar(255) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `gender` enum('女','男') DEFAULT '男' COMMENT '性别',
  `create_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '注册时间',
  `banji` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '张三', '123456', '14', '女', '2026-08-18 10:30:48', '01班');
INSERT INTO `user` VALUES ('2', '李四', '123123', '12', '男', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('3', '李四6', '123123', '12', '男', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('5', '李四1', '123123', '13', '男', '2023-10-15 14:35:00', '01班');
INSERT INTO `user` VALUES ('4', '赵六', '123456', '13', '女', '2026-08-18 10:40:45', '01班');
INSERT INTO `user` VALUES ('6', '王五1', '123789', '14', '女', '2023-10-15 14:35:00', '01班');
INSERT INTO `user` VALUES ('7', '李四2', '123123', '13', '男', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('8', '王五2', '123789', '14', '女', '2023-10-15 14:35:00', '01班');
INSERT INTO `user` VALUES ('9', '李四3', '789456', '13', '男', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('10', '小红4', '789456', '13', '男', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('11', '李四4', '456123', '13', '男', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('12', '王五5', '123789', '14', '女', '2023-10-15 14:35:00', '01班');
INSERT INTO `user` VALUES ('13', '李四5', '123123', '13', '男', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('14', '王五6', '123789', '14', '女', '2023-10-15 14:35:00', '02班');
INSERT INTO `user` VALUES ('15', '李四6', '123123', '13', '男', '2023-10-15 14:35:00', '01班');
INSERT INTO `user` VALUES ('16', '王五7', '123789', '14', '女', '2023-10-15 14:35:00', '03班');
INSERT INTO `user` VALUES ('17', '李四8', '123123', '13', '男', '2023-10-15 14:35:00', '03班');
INSERT INTO `user` VALUES ('18', '王五9', '123789', '14', '女', '2023-10-15 14:35:00', '03班');
INSERT INTO `user` VALUES ('19', '张三2', '123456', '12', '女', '2026-08-18 11:10:48', '01班');
INSERT INTO `user` VALUES ('20', '张三', '123456', '12', '女', '2026-08-18 14:00:52', null);
INSERT INTO `user` VALUES ('21', '李四', '123123', '13', '男', '2023-10-15 14:35:00', null);
